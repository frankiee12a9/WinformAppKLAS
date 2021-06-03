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
using System.Data.SqlClient;
using WindowsFormsApp_KLAS.DataProvider;
using WindowsFormsApp_KLAS.Models;


namespace WindowsFormsApp_KLAS
{
	public partial class Header : UserControl
	{
		public Header()
		{
			InitializeComponent();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			fStudentRights fStudent = new fStudentRights();
			fStudent.Hide();
			fLecturerRights fLecturer = new fLecturerRights();
			fLecturer.Hide();
			using (fLogin fLogin = new fLogin())
			{
				fLogin.ShowDialog();
			}

		}

		public void fillNameAndId(int id, string firstName, string lastName)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{
				if (connection.State == ConnectionState.Closed)
					connection.Open();
				
				string query = $"select * from Student where Id = {id}";
				var studentInfo = connection.Query<Student>(query, commandType: CommandType.Text).SingleOrDefault();
				if (studentInfo != null)
				{
					lblName.Text = firstName + " " + lastName + "(" + id.ToString() +")";
				} else
				{
					MessageBox.Show("Student with those infors not found!");
				}
			}
		}

		private void Header_Load(object sender, EventArgs e)
		{

		}
	}
}
