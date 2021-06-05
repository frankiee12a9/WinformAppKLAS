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
using Dapper;
using WindowsFormsApp_KLAS.DataProvider;
using WindowsFormsApp_KLAS.Models;

namespace WindowsFormsApp_KLAS
{
	public partial class lfLectureNotices : Form
	{
		List<Panel> listPanels = new List<Panel>();

		// update notice id
		int noticeId = 0;

		public static int _loggedId;

		public lfLectureNotices()
		{
			InitializeComponent();
		}

		// get `text box data` from `login` form
		public lfLectureNotices(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		public int LoggedId { get; set; } = _loggedId;


		private void btnNoticeChange_Click(object sender, EventArgs e)
		{
			panelCrud.Show();
			panelCrud.BringToFront();
			panelCrud.Focus();
			try
			{
				using (IDbConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
				{
					connection.Open();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void lfLectureNotices_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'kLAS_DBDataSet3.LectureNotice' table. You can move, or remove it, as needed.
			this.lectureNoticeTableAdapter.Fill(this.kLAS_DBDataSet3.LectureNotice);
			fillLabelData();
			fillInCbxCouresHelper();

			// display cbxSemeter[0] and cbxCourses[0] when form is loaded
			cbxSemester.SelectedIndex =  0;
			cbxCourses.SelectedIndex = 0;

			listPanels.Add(panelHeader);
			listPanels.Add(panelMiddle);
			listPanels.Add(panelCrud);
			panelCrud.Hide();
			panelCrud.Visible = false;
			try
			{
				fillLectureNoticeDgv();
				clearText();
			}
			catch (Exception ex)
			{
				MessageBox.Show("fLectureNotices_load" + ex.Message);
			}

			// handle `insert_identity is off` from SQL 
			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				string query = @"set identity_insert LectureNotice on";
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				connection.Close();
			}
		}

		private void panelCrud_Paint(object sender, PaintEventArgs e)
		{

		}

		// insert query
		private void btnCrudInsert_Click(object sender, EventArgs e)
		{
			string query = @"insert into LectureNotice(NoticeTitle, NoticeContent, CreatedDate, LecturerId, CreatedBy, CourseId) 
			values(@NoticeTitle, @NoticeContent, @CreatedDate, @LecturerId, @CreatedBy, @CourseId)";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					if (connection.State == ConnectionState.Closed)
						connection.Open();

					SqlCommand cmd = new SqlCommand(query, connection);
					// cmd.Parameters.AddWithValue("@NoticeId", noticeId);
					cmd.Parameters.AddWithValue("@NoticeId", noticeId);
					cmd.Parameters.AddWithValue("@NoticeTitle", txtTitle.Text.Trim());
					cmd.Parameters.AddWithValue("@NoticeContent", txtContent.Text.Trim());
					cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
					cmd.Parameters.AddWithValue("@LecturerId", int.Parse(txtLecturerId.Text.Trim()));
					cmd.Parameters.AddWithValue("@CreatedBy", txtLecturer.Text.Trim());
					cmd.Parameters.AddWithValue("@CourseId", int.Parse(txtCourseId.Text));

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex) 
				{
					MessageBox.Show("btnCrudInsert" + ex.Message);
				}

				fillLectureNoticeDgv();
				connection.Close();

				MessageBox.Show("query executed successfully");
				clearText();
			}
		}

		private void btnCrudCancel_Click(object sender, EventArgs e)
		{
			clearText();
		}

		// update query
		private void btnCrudUpdate_Click(object sender, EventArgs e)
		{
			string query = $@"update LectureNotice set NoticeTitle=@NoticeTitle, CreatedDate=@CreatedDate, NoticeContent=@NoticeContent
							where NoticeId={noticeId}";
			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);

					cmd.Parameters.AddWithValue("@NoticeTitle", txtTitle.Text.Trim());
					cmd.Parameters.AddWithValue("@NoticeContent", txtContent.Text.Trim());
					cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
					/*cmd.Parameters.AddWithValue("@LecturerId", int.Parse(txtLecturerId.Text.Trim()));
					cmd.Parameters.AddWithValue("@CreatedBy", txtLecturer.Text.Trim());
					cmd.Parameters.AddWithValue("@CourseId", int.Parse(txtCourseId.Text.Trim()));*/

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				fillLectureNoticeDgv();
				connection.Close();
				// clear current text 
				clearText();
			}
		}

		// delete query
		private void btnCrudDel_Click(object sender, EventArgs e)
		{
			string query = $@"delete LectureNotice where NoticeId={noticeId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);

					cmd.Parameters.AddWithValue("@NoticeId", noticeId.ToString());
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("btnCrudDel" + ex.Message);
				}

				clearText();
				fillLectureNoticeDgv();
			}
		}

		// clear current text in textBox
		private void clearText()
		{
			txtCourseId.Text= "";
			txtLecturer.Text = "";
			txtTitle.Text = "";
			txtLecturerId.Text= "";
			txtContent.Text = "";
		}


		public void fillLectureNoticeDgv()
		{
			string query = $@"select * from LectureNotice where LecturerId = {_loggedId}";

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

					// fill dataset with query result
					dAdapter.Fill(dSet);

					// *dAdapter.Fill(dTable);

					// set dgv control = readonly 
					dgvLectureNotices.ReadOnly = true;

					// set the dgv control's data source/data table 
					dgvLectureNotices.DataSource = dSet.Tables[0];

					// *dgvLectureNotices.DataSource = dTable;

					connection.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("fillLectureNoticeDgv" + ex.Message);
				}
			}
		}

		private void label13_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (fLecturerRights fLecturerRight = new fLecturerRights())
			{
				fLecturerRight.ShowDialog();
				fLecturerRight.BringToFront();
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (fLogin fLogin = new fLogin())
			{
				fLogin.ShowDialog();
				fLogin.BringToFront();
			}
		}

		private void dgvLectureNotices_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MessageBox.Show("cell content double click!");
		}

		private void updateDgvContents()
		{
			if (dgvLectureNotices.CurrentRow.Index != -1)
			{
				txtTitle.Text = dgvLectureNotices.CurrentRow.Cells[1].Value.ToString();
				txtContent.Text = dgvLectureNotices.CurrentRow.Cells[2].Value.ToString();
				// save id for update 
				noticeId = int.Parse(dgvLectureNotices.CurrentRow.Cells[0].Value.ToString());
				btnCrudUpdate.Focus();
			}
		}

		private void dgvLectureNotices_DoubleClick(object sender, EventArgs e)
		{
			updateDgvContents();
		}


		// fill `id and name` of current logged in user into label 
		private void fillLabelData()
		{
			try
			{
				string query = $@"select LecturerId, CreatedBy from LectureNotice where LecturerId = {_loggedId}";
				using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
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
							string name = dr["CreatedBy"].ToString();
							string id = dr["LecturerId"].ToString();
							lblNameAndId.Text = name + "(" + id.ToString() + ")";
						}
					
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("fillLabelData " + ex.Message);
			}
		}

		//  fill courseName into cbxCourses
		private void fillInCbxCourse(int courseId)
		{
			string query = $@"select Course.CourseName from Course left join LecturerCourse on LecturerCourse.CourseId = Course.CourseId
							where Course.CourseId = {courseId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					if (!dr.Read())
					{
						MessageBox.Show("fillInCbxCourse: Source is empty!");
					}
					else
					{
						string courseName = dr["CourseName"].ToString();
						cbxCourses.Items.Add(courseName);
					}
				}
			}
		}

		// fill course name helper 
		private void fillInCbxCouresHelper()
		{
			int courseId;

			if (_loggedId == 2001)
			{
				courseId = 3001;
				fillInCbxCourse(courseId);
			}
			else if (_loggedId == 2002)
			{
				courseId = 3002;
				fillInCbxCourse(courseId);
			}
			else if (_loggedId == 2003)
			{
				courseId = 3003;
				fillInCbxCourse(courseId);
			}
			else if (_loggedId == 2004)
			{
				courseId = 3004;
				fillInCbxCourse(courseId);
			}
			else if (_loggedId == 2005)
			{
				courseId = 3005;
				fillInCbxCourse(courseId);
			}
		}


		private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbxMenu.SelectedItem)
			{
				case "공지사항":
					this.Hide();
					using (lfLectureNotices lfLectureNotice = new lfLectureNotices())
					{
						lfLectureNotice.ShowDialog();
						lfLectureNotice.BringToFront();
						lfLectureNotice.Focus();
					}
					break;
				case "강의자료실":
					this.Hide();
					using (lfLectureNotes lfLectureNote = new lfLectureNotes())
					{
						lfLectureNote.ShowDialog();
						lfLectureNote.BringToFront();
						lfLectureNote.Focus();
					}
					break;
				case "강의계획서":
					this.Hide();
					using (lfLectureSyllabus lfLectureSyllabus = new lfLectureSyllabus())
					{
						lfLectureSyllabus.ShowDialog();
						lfLectureSyllabus.BringToFront();
						lfLectureSyllabus.Focus();
					}
					break;

				default:
					break;
			}
		}
	}
}
