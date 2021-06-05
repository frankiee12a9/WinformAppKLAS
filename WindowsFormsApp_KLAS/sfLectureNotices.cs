using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_KLAS.DataProvider;

namespace WindowsFormsApp_KLAS
{
	public partial class sfLectureNotices : Form
	{
		public static int _loggedId;

		public sfLectureNotices()
		{
			InitializeComponent();
		}

		public sfLectureNotices(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		// store all of `panelMiddle2`
		public Panel PanelContainer
		{
			get { return panelMiddle2; } 

			set { panelMiddle2 = value; }
		}

		private void sfLectureNotices_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'kLAS_DBDataSet.LectureNotice' table. You can move, or remove it, as needed.
			// this.lectureNoticeTableAdapter.Fill(this.kLAS_DBDataSet.LectureNotice);
			MessageBox.Show("you are logged in as user's id: " + _loggedId);
			fillLabelData();
			cbxCourseInfo.SelectedIndex = 0; // display colum 1's info in combo box 
		}

		private void label1_Click(object sender, EventArgs e)
		{
			lblLogoClickEvent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			lblLogoClickEvent();
		}

		// back to main form
		private void lblLogoClickEvent()
		{
			this.Hide();
			using (fStudentRights fStudentRight = new fStudentRights())
			{
				fStudentRight.ShowDialog();
				fStudentRight.BringToFront();
			}
		}

		// back to login form
		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (fLogin fLogin = new fLogin())
			{
				fLogin.ShowDialog();
				fLogin.BringToFront();
				fLogin.Focus();
			};
		}

		private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbxMenu.SelectedItem)
			{
				case "공지사항":
					this.Hide();
					using (sfLectureNotices fLectureNotice = new sfLectureNotices())
					{
						fLectureNotice.ShowDialog();
						fLectureNotice.BringToFront();
						fLectureNotice.Focus();
					}
					break;
				case "강의자료실":
					this.Hide();
					using (sfLectureNotes fLectureNote = new sfLectureNotes())
					{
						fLectureNote.ShowDialog();
						fLectureNote.BringToFront();
						fLectureNote.Focus();
					}
					break;
				case "강의계획서":
					this.Hide();
					using (sfLectureSyllabus fLectureSyllabus = new sfLectureSyllabus())
					{
						fLectureSyllabus.ShowDialog();
						fLectureSyllabus.BringToFront();
						fLectureSyllabus.Focus();
					}
					break;

				default:
					break;
			}
		}

		private void cbxCourseInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			int lecturerId;

			switch (cbxCourseInfo.SelectedItem)
			{
				case "알고리즘":
				{
					lecturerId = 2005;
					fillLabelData2(lecturerId);
					fillLectureNoticeDgv(lecturerId);
					break;
				}
				case "자료구조":
				{
					lecturerId = 2001;
					fillLabelData2(lecturerId);
					fillLectureNoticeDgv(lecturerId);
					break;
				}

				case "이산구조":
				{
					lecturerId = 2002;
					fillLabelData2(lecturerId);
					fillLectureNoticeDgv(lecturerId);
					break;
				}

				case "데이터베이스":
				{
					lecturerId = 2004;
					fillLabelData2(lecturerId);
					fillLectureNoticeDgv(lecturerId);
					break;
				}

				case "기계학습":
				{
					lecturerId = 2003;
					fillLabelData2(lecturerId);
					fillLectureNoticeDgv(lecturerId);
					break;
				}

				default:
					break;
			}
		}

		// fill data in label: Course/CourseId - Time/Place - LecturerName
		private void fillLabelData2(int lecturerId)
		{
			string query = $@"select Class.CourseName, Class.CourseId, Class.Class1Time, Class.Class2Time, Class.Class1Place, Class.Class2Place, Lecturer.FirstName, Lecturer.LastName
							from Class left join Lecturer on Lecturer.Id = Class.LecturerId
							where Class.LecturerId = {lecturerId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
					using (SqlDataReader dataReader = cmd.ExecuteReader())
					{
						if (!dataReader.Read())
						{
							MessageBox.Show("fillLabelData2: SqlDataReader is empty");
							return;
						}
						else
						{
							string courseName = dataReader["CourseName"].ToString();
							string courseId = dataReader["CourseId"].ToString();
							string class1Time = dataReader["Class1Time"].ToString();
							string class2Time = dataReader["Class2Time"].ToString();
							string class1Place = dataReader["Class1Place"].ToString();
							string class2Place = dataReader["Class2Place"].ToString();
							string lecturerFirstName = dataReader["FirstName"].ToString();
							string lecturerLastName = dataReader["LastName"].ToString();
							lblCourseName_Id_lecturer.Text = courseName + "(" + courseId + ")" + " - " + lecturerFirstName + lecturerLastName;
							lblCourseTime_Place.Text = class1Time + "/" + class2Place + ", " +  class2Time + "/" + class2Place;
						}
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("fillLabeData2: " + ex.Message);
				}

				connection.Close();
			}
		}

		/*private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
			{
				if (string.IsNullOrEmpty(txtSearch.Text))
				{
					lectureNoticeBindingSource.Filter = string.Empty;
				}
				else
				{
					try
					{
						lectureNoticeBindingSource.Filter = string.Format("{0} LIKE '{1}*'", cbxSearchBased.Text, txtSearch.Text);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}*/

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string field;
			string fieldValue;
			int lecturerId;

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					if (cbxSearchBased.Text == "천제")
					{
						if (cbxCourseInfo.Text == "알고리즘")
						{
							lecturerId = 2005;
							fillLectureNoticeDgv(lecturerId);
						}
						else if (cbxCourseInfo.Text == "자료구조")
						{
							lecturerId = 2001;
							fillLectureNoticeDgv(lecturerId);
						}
						else if (cbxCourseInfo.Text == "이산구조")
						{
							lecturerId = 2002;
							fillLectureNoticeDgv(lecturerId);
						}
						else if (cbxCourseInfo.Text == "데이터베이스")
						{
							lecturerId = 2004;
							fillLectureNoticeDgv(lecturerId);
						}
						else if (cbxCourseInfo.Text == "기계학습")
						{
							lecturerId = 2003;
							fillLectureNoticeDgv(lecturerId);
						}
					}
					else if (cbxSearchBased.Text == "제목")
					{
						field = "NoticeTitle";
						fieldValue = txtSearch.Text.Trim();

						if (cbxCourseInfo.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						 else if (cbxCourseInfo.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "기계학습")
						{
							lecturerId = 2003;
							searchBasedField(lecturerId, field, fieldValue);
						}
					}
					else if (cbxSearchBased.Text == "내용")
					{
						field = "NoticeContent";
						fieldValue = txtSearch.Text.Trim();

						if (cbxCourseInfo.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "기계학습")
						{
							lecturerId = 2003;
							searchBasedField(lecturerId, field, fieldValue);
						}
					}
					else if (cbxSearchBased.Text == "작성자")
					{
						field = "CreatedBy";
						fieldValue = txtSearch.Text.Trim();

						if (cbxCourseInfo.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxCourseInfo.Text == "기계학습")
						{
							lecturerId = 2003;
							searchBasedField(lecturerId, field, fieldValue);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				connection.Close();
			}
		}

		private void searchBasedField(int lecturerId, string field, string fieldValue)
		{
			string query = $@"select NoticeId, NoticeTitle, NoticeContent, CreatedDate, CreatedBy, NoticeViewNumber from 
							LectureNotice where LecturerId = {lecturerId} and {field} LIKE '{fieldValue}_%'";
			
			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try 
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
					SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
					DataSet dSet = new DataSet();
					dAdapter.Fill(dSet);
					dgvLectureNotice.DataSource = dSet.Tables[0];
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				connection.Close();
			}
		}

		private void cbxSearchBased_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void fillLabelData()
		{
			string query = $@"select Id, FirstName, LastName from Student where Id = {_loggedId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
					using (SqlDataReader dr = cmd.ExecuteReader()) // read data from sql 
					{
						if (!dr.Read())
						{
							MessageBox.Show("fillLabelData: SqlDataReader is empty");
							return;
						}
						else
						{
							string fname = dr["FirstName"].ToString();
							string lname = dr["LastName"].ToString();
							string id = dr["Id"].ToString();
							lblNameAndId.Text = fname + " " + lname + "(" + id.ToString() + ")";
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("fillLabelData " + ex.Message);
				}
			}
		}


		public void fillLectureNoticeDgv(int lecturerId)
		{
			string query = $@"select * from LectureNotice where LecturerId = {lecturerId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();

					// define sql command object 
					SqlCommand cmd = new SqlCommand(query, connection);

					// set SqlDataAdapter object 
					SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

					// define dataset
					DataSet dSet = new DataSet();

					// *DataTable dTable = new DataTable();

					// fill dataset with query result
					dAdapter.Fill(dSet);

					// *dAdapter.Fill(dTable);

					// set dgv control = readonly 
					dgvLectureNotice.ReadOnly = true;

					// set the dgv control's data source/data table 
					dgvLectureNotice.DataSource = dSet.Tables[0];

					// *dgvLectureNotices.DataSource = dTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("fillLectureNoticeDgv: " + ex.Message);
				}

				connection.Close();

				MessageBox.Show("query executed successfully!");
			}
		}

		private void sfLectureNotices_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
		}
	}
}
