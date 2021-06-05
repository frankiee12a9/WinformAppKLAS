using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using WindowsFormsApp_KLAS.DataProvider;
using System.Data.SqlClient;

namespace WindowsFormsApp_KLAS
{
	public partial class lfLectureNotes : Form
	{
		// list of panels in current form 
		List<Panel> listPanels = new List<Panel>();

		// store current logged in user's id 
		// retrieving data from sql based on user's id purpose 
		public static int _loggedId;

		// update note id 
		int noteId = 0;

		public lfLectureNotes()
		{
			InitializeComponent();
		}
		
		// get current logged in user's id
		public lfLectureNotes(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		public int LoggedId { get; set; } = _loggedId;


		private void fLectureNotes_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'kLAS_DBDataSet2.LectureNote' table. You can move, or remove it, as needed.
			this.lectureNoteTableAdapter.Fill(this.kLAS_DBDataSet2.LectureNote);
			fillLabelData();
			fillInCbxCouresHelper();
			cbxSemester.SelectedIndex = 0;
			cbxCourses.SelectedIndex = 0;

			// add total panels in current form
			listPanels.Add(panelHeader);
			listPanels.Add(panelMiddle1);
			listPanels.Add(panelMiddle2);
			listPanels.Add(panelCrud);
			panelCrud.Hide();
			panelCrud.Visible = false;
			try
			{
				fillLectureNotesDgv();
				clearText();
			}
			catch (Exception ex)
			{
				MessageBox.Show("fLectureNotice load" + ex.Message);
			}

			// handle `insert_identity is off` from sql 
			/*using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				string query = @"set identity_insert LectureNote on";
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				connection.Close();
			}*/
		}

		private void btnNotesChange_Click(object sender, EventArgs e)
		{
			panelCrud.Show();
			panelCrud.BringToFront();
			panelCrud.Focus();
			try
			{
				using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
				{
					connection.Open();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// fill courseName into cbxCourses
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


		private void fillLectureNotesDgv()
		{
			string query = $@"select * from LectureNote where LecturerId = {_loggedId}";

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
					dgvLectureNotes.ReadOnly = true;

					// set the dgv control's data source/data table 
					dgvLectureNotes.DataSource = dSet.Tables[0];

					// *dgvLectureNotices.DataSource = dTable;

					connection.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("fillLectureNoteDgv: " + ex.Message);
				}
			}
		}

		private void btnCrudUpdate_Click(object sender, EventArgs e)
		{
			string query = $@"update LectureNote set NoteTitle=@NoteTitle, CreatedDate=@CreatedDate, NoteContent=@NoteContent
							where NoteId={noteId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);
				
					cmd.Parameters.AddWithValue("@NoteTitle", txtTitle.Text.Trim());
					cmd.Parameters.AddWithValue("@NoteContent", txtContent.Text.Trim());
					cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
					/*cmd.Parameters.AddWithValue("@LecturerId", int.Parse(txtLecturerId.Text.Trim()));
					cmd.Parameters.AddWithValue("@CreatedBy", txtLecturer.Text.Trim());
					cmd.Parameters.AddWithValue("@CourseId", int.Parse(txtCourseId.Text.Trim()));*/

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("btnCrudUpdate: " + ex.Message);	
				}

				clearText();
				fillLectureNotesDgv();
				connection.Close();
			}
		}

		private void btnCrudDel_Click(object sender, EventArgs e)
		{
			clearText();
			string query = $@"delete LectureNote where NoticeId={noteId}";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand(query, connection);

					cmd.Parameters.AddWithValue("@NoteId", noteId.ToString());
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("btnCrudDel" + ex.Message);
				}

				clearText();
				fillLectureNotesDgv();
			}
		}

		private void btnCrudInsert_Click(object sender, EventArgs e)
		{
			string query = @"insert into LectureNote(NoteTitle, NoteContent, CreatedDate, LecturerId, CreatedBy, CourseId) 
			values(@NoteTitle, @NoteContent, @CreatedDate, @LecturerId, @CreatedBy, @CourseId)";

			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				try
				{
					if (connection.State == ConnectionState.Closed)
						connection.Open();

					SqlCommand cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@NoteId", noteId++);
					cmd.Parameters.AddWithValue("@NoteTitle", txtTitle.Text.Trim());
					cmd.Parameters.AddWithValue("@NoteContent", txtContent.Text.Trim());
					cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
					cmd.Parameters.AddWithValue("@LecturerId", int.Parse(txtLecturerId.Text.Trim()));
					cmd.Parameters.AddWithValue("@CreatedBy", txtLecturer.Text.Trim());
					cmd.Parameters.AddWithValue("@CourseId", int.Parse(txtCourseId.Text));

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("btnCrudInsert: " + ex.Message);
				}

				connection.Close();
				fillLectureNotesDgv();
				clearText();
			}
		}

		private void btnCrudCancel_Click(object sender, EventArgs e)
		{
			clearText();
		}

		private void clearText()
		{
			txtCourseId.Text= "";
			txtLecturer.Text = "";
			txtTitle.Text = "";
			txtContent.Text = "";
			txtLecturerId.Text= "";
			txtContent.Text = "";
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

		private void lblLogo1_Click(object sender, EventArgs e)
		{
			showFLectureRight();
		}

		private void lblLogo2_Click(object sender, EventArgs e)
		{
			showFLectureRight();
		}
		
		// show `lectureRight` form 
		private void showFLectureRight()
		{
			this.Hide();
			using (fLecturerRights fLecturerRight = new fLecturerRights())
			{
				fLecturerRight.ShowDialog();
				fLecturerRight.BringToFront();
			}
		}

		private void dgvLectureNotes_DoubleClick(object sender, EventArgs e)
		{
			updateDgvContents();
		}

		private void updateDgvContents()
		{
			if (dgvLectureNotes.CurrentRow.Index != -1)
			{
				txtTitle.Text = dgvLectureNotes.CurrentRow.Cells[1].Value.ToString();
				txtContent.Text = dgvLectureNotes.CurrentRow.Cells[2].Value.ToString();
				// save id for update 
				noteId = int.Parse(dgvLectureNotes.CurrentRow.Cells[0].Value.ToString());
				btnCrudUpdate.Focus();
			}
		}

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
