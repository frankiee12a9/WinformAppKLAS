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
	public partial class sfLectureNotes : Form
	{
		public static int _loggedId;

		public sfLectureNotes()
		{
			InitializeComponent();
		}

		public sfLectureNotes(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		private void label1_Click(object sender, EventArgs e)
		{
			lblLogoClickEvent();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			lblLogoClickEvent();
		}

		private void lblLogoClickEvent()
		{
			this.Hide();
			using (fStudentRights fStudentRight = new fStudentRights())
			{
				fStudentRight.ShowDialog();
				fStudentRight.BringToFront();
			}
		}

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
						break;
					}

				case "강의자료실":
					this.Hide();
					using (sfLectureNotes fLectureNote = new sfLectureNotes())
					{
						fLectureNote.ShowDialog();
						fLectureNote.BringToFront();
						fLectureNote.Focus();
						break;
					}
			
				case "강의계획서":
					this.Hide();
					using (sfLectureSyllabus fLectureSyllabus = new sfLectureSyllabus())
					{
						fLectureSyllabus.ShowDialog();
						fLectureSyllabus.BringToFront();
						fLectureSyllabus.Focus();
						break;
					}

				default:
					break;
			}
		}

		private void sfLectureNotes_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'kLAS_DBDataSet1.LectureNote' table. You can move, or remove it, as needed.
			this.lectureNoteTableAdapter.Fill(this.kLAS_DBDataSet1.LectureNote);
			MessageBox.Show("you are logged in as user's id: " + _loggedId);
			fillLabelData();
		}

		private void fillLectureNotesDgv(int lecturerId)
		{
			string query = $@"select * from LectureNote where LecturerId = {lecturerId}";
			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
					SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
					DataSet dSet = new DataSet();
					dAdapter.Fill(dSet);
					dgvLectureNotes.ReadOnly = true;
					dgvLectureNotes.DataSource = dSet.Tables[0];
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
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
							MessageBox.Show("fillLabelData: current resource is empty.");
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
						if (cbxSelectCourse.Text == "알고리즘")
						{
							lecturerId = 2005;
							fillLectureNotesDgv(lecturerId);
						}
						else if (cbxSelectCourse.Text == "자료구조")
						{
							lecturerId = 2001;
							fillLectureNotesDgv(lecturerId);
						}
						else if (cbxSelectCourse.Text == "이산구조")
						{
							lecturerId = 2002;
							fillLectureNotesDgv(lecturerId);
						}
						else if (cbxSelectCourse.Text == "데이터베이스")
						{
							lecturerId = 2004;
							fillLectureNotesDgv(lecturerId);
						}
						else if (cbxSelectCourse.Text == "기계학습")
						{
							lecturerId = 2003;
							fillLectureNotesDgv(lecturerId);
						}
					}
					else if (cbxSearchBased.Text == "제목")
					{
						field = "NoteTitle";
						fieldValue = txtSearch.Text.Trim();

						if (cbxSelectCourse.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "기계학습")
						{
							lecturerId = 2003;
							searchBasedField(lecturerId, field, fieldValue);
						}
					}
					else if (cbxSearchBased.Text == "내용")
					{
						field = "NoteContent";
						fieldValue = txtSearch.Text.Trim();

						if (cbxSelectCourse.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "기계학습")
						{
							lecturerId = 2003;
							searchBasedField(lecturerId, field, fieldValue);
						}
					}
					else if (cbxSearchBased.Text == "작성자")
					{
						field = "CreatedBy";
						fieldValue = txtSearch.Text.Trim();

						if (cbxSelectCourse.Text == "알고리즘")
						{
							lecturerId = 2005;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "자료구조")
						{
							lecturerId = 2001;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "이산구조")
						{
							lecturerId = 2002;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "데이터베이스")
						{
							lecturerId = 2004;
							searchBasedField(lecturerId, field, fieldValue);
						}
						else if (cbxSelectCourse.Text == "기계학습")
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

		// helper function: search based lecturerId, column, column value 
		private void searchBasedField(int lecturerId, string field, string fieldValue)
		{
			string query = $@"select NoteId, NoteTitle, NoteContent, CreatedDate, CreatedBy, NoteViewsNumber from 
							LectureNote where LecturerId = {lecturerId} and {field} LIKE '{fieldValue}_%'";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
					SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
					DataSet dSet = new DataSet();
					dAdapter.Fill(dSet);
					dgvLectureNotes.DataSource = dSet.Tables[0];
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				connection.Close();
			}
		}

		private void cbxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
		{
			int lecturerId;

			switch (cbxSelectCourse.SelectedItem)
			{
				case "알고리즘":
				{
					lecturerId = 2005;
					fillLabelData2(lecturerId);
					fillLectureNotesDgv(lecturerId);
					break;
				}
				case "자료구조":
				{
					lecturerId = 2001;
					fillLabelData2(lecturerId);
					fillLectureNotesDgv(lecturerId);
					break;
				}

				case "이산구조":
				{
					lecturerId = 2002;
					fillLabelData2(lecturerId);
					fillLectureNotesDgv(lecturerId);
					break;
				}

				case "데이터베이스":
				{
					lecturerId = 2004;
					fillLabelData2(lecturerId);
					fillLectureNotesDgv(lecturerId);
					break;
				}

				case "기계학습":
				{
					lecturerId = 2003;
					fillLabelData2(lecturerId);
					fillLectureNotesDgv(lecturerId);
					break;
				}

				default:
					break;
			}
		}

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
				catch (Exception ex)
				{
					MessageBox.Show("fillLabeData2: " + ex.Message);
				}

				connection.Close();
			}
		}
	}
}
