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
	public partial class sfLectureSyllabus : Form
	{
		public static int _loggedId;

		public sfLectureSyllabus()
		{
			InitializeComponent();
		}

		public sfLectureSyllabus(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		private void sfLectureSyllabus_Load(object sender, EventArgs e)
		{
			fillLabelData();
		}


		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{
			lblLogoClickEvent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
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
				case "Lecture Notices":
					this.Hide();
					using (sfLectureNotices fLectureNotice = new sfLectureNotices())
					{
						fLectureNotice.ShowDialog();
						fLectureNotice.BringToFront();
						fLectureNotice.Focus();
					}
					break;
				case "Lecture Notes":
					this.Hide();
					using (sfLectureNotes fLectureNote = new sfLectureNotes())
					{
						fLectureNote.ShowDialog();
						fLectureNote.BringToFront();
						fLectureNote.Focus();
					}
					break;
				case "Lecture Syllabus":
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

	}
}
