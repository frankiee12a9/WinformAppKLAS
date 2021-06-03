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
	public partial class fLecturerRights : Form
	{

		public static int _loggedId;

		public fLecturerRights()
		{
			InitializeComponent();
		}

		public fLecturerRights(string loggedId)
		{
			_loggedId = int.Parse(loggedId);
		}

		public int LoggedId { get; set; } = _loggedId;

		private void fLecturerRights_Load(object sender, EventArgs e)
		{
			fillLabelData();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLectureNotes_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (lfLectureNotes fLectureNote = new lfLectureNotes())
			{
				fLectureNote.ShowDialog();
				fLectureNote.BringToFront();
			}
		}

		private void btnLectureNotices_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (lfLectureNotices fLectureNotice = new lfLectureNotices())
			{
				fLectureNotice.ShowDialog();
				fLectureNotice.BringToFront();
			}
		}

		private void btnLectureSyllabus_Click(object sender, EventArgs e)
		{
			this.Hide();
			using (lfLectureSyllabus fLectureSyllabus = new lfLectureSyllabus())
			{
				fLectureSyllabus.ShowDialog();
				fLectureSyllabus.BringToFront();
			}
		}

		/*private void fillLabelData()
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

			MessageBox.Show("label data was filed");
		}*/

		private void fillLabelData()
		{
			try
			{
				string query = $@"select Id, FirstName, LastName from Lecturer where Id = {_loggedId}";
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
							string fname = dr["FirstName"].ToString();
							string lname = dr["LastName"].ToString();
							string id = dr["Id"].ToString();
							lblNameAndId.Text = fname + " " + lname + "(" + id.ToString() + ")";
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("fillLabelData " + ex.Message);
			}

			MessageBox.Show("label data was filed");
		}

		/*	private void panelHeader_Load(object sender, EventArgs e)
			{

			}*/

		/*private void lblNameAndId_Click(object sender, EventArgs e)
		{

		}*/
	}
}
