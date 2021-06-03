using Dapper;
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
using WindowsFormsApp_KLAS.Models;


namespace WindowsFormsApp_KLAS
{
	public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Id and Password fields must be filled.");
				txtId.Focus();
				return;
			}

			string query = $"select * from LoginInfo where LecturerId = {txtId.Text} or StudentId = {txtId.Text}";

			try
			{
				using(SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
				{
					if (connection.State == ConnectionState.Closed)
						connection.Open();

					var loginInfo = connection.Query<LoginInfo>(query, commandType: CommandType.Text).SingleOrDefault();
					if (loginInfo != null)
					{
						if (txtId.Text == loginInfo.StudentId.ToString())
						{
							if (txtPassword.Text == loginInfo.StudentPassword)
							{
								getDataFromCurrentLoggedStudent();
								fStudentRights fStudent = new fStudentRights();
								this.Hide();
								fStudent.ShowDialog();
							}
						} 
						else if (txtId.Text == loginInfo.LecturerId.ToString())
						{
							if (txtPassword.Text == loginInfo.LecturerPassword)
							{
								getDataFromCurrentLoggedLecturer();
								fLecturerRights fLecturer = new fLecturerRights();
								this.Hide();
								fLecturer.ShowDialog();
							}
						} else
						{
							MessageBox.Show(this, "Your Id or password is not correct!");
						}
					}
				};
			} catch(Exception ex)
			{
				MessageBox.Show("btnLogin_Click" + ex.Message);
			}
 		}

		// get data from current logged in `lecturer`
		private void getDataFromCurrentLoggedLecturer()
		{
			// lecturer fields
			lfLectureNotices lfLectureNotice = new lfLectureNotices(txtId.Text); //  for LectureNotice form 
			fLecturerRights fLectureRight = new fLecturerRights(txtId.Text);    // for fLectureRight form
			lfLectureNotes lfLectureNote = new lfLectureNotes(txtId.Text);      // for LectureNote form
		}


		// get data from current logged in `student`
		private void getDataFromCurrentLoggedStudent()
		{
			fStudentRights fStudentRight = new fStudentRights(txtId.Text);
			sfLectureNotes sfLectureNote = new sfLectureNotes(txtId.Text);
			sfLectureNotices sfLectureNotice = new sfLectureNotices(txtId.Text);
			sfLectureSyllabus sfLectureSyllabus = new sfLectureSyllabus(txtId.Text);
		}

		private void fLogin_Load(object sender, EventArgs e)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
				{
					connection.Open();
				}
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			MessageBox.Show("Connected to database successfully!");
		}
	}
}
