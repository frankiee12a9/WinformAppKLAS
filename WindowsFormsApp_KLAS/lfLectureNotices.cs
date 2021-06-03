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

			MessageBox.Show("Database connection is ready!");
		}

		private void lfLectureNotices_Load(object sender, EventArgs e)
		{
			fillLabelData();

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
				MessageBox.Show("fLectureNotice load" + ex.Message);
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
				catch (Exception ex) {
					MessageBox.Show("btnCrudInsert" + ex.Message);
				}

				connection.Close();

				MessageBox.Show("query executed successfully");
			}
		}

		private void btnCrudCancel_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
			{

			}
		}

		/*private void btnCrudSearch_Click(object sender, EventArgs e)
		{

			string query = @"select * from LectureNotice 
							where Search";
			try
			{
				using (SqlConnection connection = new SqlConnection(Helper.ConnectionHelper("KLAS_DB")))
				{

					// define sql command object 
					SqlCommand cmd = new SqlCommand("LectureNoticeViewOrSearch", connection);

					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@value", "txtSearch.Text");

					connection.Open();

					cmd.ExecuteNonQuery();



					// set SqlDataAdapter object 
					SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

					// define dataset
					DataSet dSet = new DataSet();

					// *DataTable dTable = new DataTable();

					// fill dataset with query result
					dAdapter.Fill(dSet);

					// *dAdapter.Fill(dTable);

					// set dgv control = readonly 
					// dgvLectureNotices.ReadOnly = true;

					// set the dgv control's data source/data table 
					dgvLectureNotices.DataSource = dSet.Tables[0];

					// *dgvLectureNotices.DataSource = dTable;


					connection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("fillLectureNoticeDgv" + ex.Message);
			}

			MessageBox.Show("query executed successfully!");
		}*/


		private void btnCrudUpdate_Click(object sender, EventArgs e)
		{
			// clear current text 
			clearText(); 

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
				MessageBox.Show("query executed successfully!");
			}
		}

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

				MessageBox.Show("query executed succesfully!");
				clearText();
				fillLectureNoticeDgv();

			}
		}


		private void clearText()
		{
			txtCourseId.Text= "";
			txtLecturer.Text = "";
			txtTitle.Text = "";
			txtLecturerId.Text= "";
		}


		public void fillLectureNoticeDgv()
		{
			MessageBox.Show("Logged current user's id: " + _loggedId);
			// string query = $@"select * from LectureNotice where CourseId=@{CourseIdList[1].ToString()}";
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

					// *DataTable dTable = new DataTable();

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

				MessageBox.Show("query executed successfully!");
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
			MessageBox.Show("double click!");
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
	}
}
