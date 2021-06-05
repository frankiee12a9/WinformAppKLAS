
namespace WindowsFormsApp_KLAS
{
	partial class sfLectureNotices
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.cbxMenu = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblNameAndId = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblLogo2 = new System.Windows.Forms.Label();
			this.lblLogo1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelFooter = new WindowsFormsApp_KLAS.Footer();
			this.lblCourseTime_Place = new System.Windows.Forms.Label();
			this.lblCourseName_Id_lecturer = new System.Windows.Forms.Label();
			this.panelMiddle2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvLectureNotice = new System.Windows.Forms.DataGridView();
			this.noticeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeViewNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lectureNoticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kLAS_DBDataSet = new WindowsFormsApp_KLAS.KLAS_DBDataSet();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnTextSearch = new System.Windows.Forms.Button();
			this.cbxSearchBased = new System.Windows.Forms.ComboBox();
			this.panelMiddle1 = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxCourseInfo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lectureNoticeTableAdapter = new WindowsFormsApp_KLAS.KLAS_DBDataSetTableAdapters.LectureNoticeTableAdapter();
			this.panel1.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelMiddle2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoticeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet)).BeginInit();
			this.panelMiddle1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelHeader);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(996, 86);
			this.panel1.TabIndex = 2;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.IndianRed;
			this.panelHeader.Controls.Add(this.cbxMenu);
			this.panelHeader.Controls.Add(this.panel4);
			this.panelHeader.Controls.Add(this.panel5);
			this.panelHeader.Location = new System.Drawing.Point(-1, 4);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(994, 78);
			this.panelHeader.TabIndex = 1;
			// 
			// cbxMenu
			// 
			this.cbxMenu.FormattingEnabled = true;
			this.cbxMenu.Items.AddRange(new object[] {
            "공지사항",
            "강의자료실",
            "강의계획서"});
			this.cbxMenu.Location = new System.Drawing.Point(315, 32);
			this.cbxMenu.Name = "cbxMenu";
			this.cbxMenu.Size = new System.Drawing.Size(121, 20);
			this.cbxMenu.TabIndex = 4;
			this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnLogout);
			this.panel4.Controls.Add(this.lblNameAndId);
			this.panel4.Location = new System.Drawing.Point(711, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(283, 78);
			this.panel4.TabIndex = 3;
			// 
			// btnLogout
			// 
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogout.Location = new System.Drawing.Point(158, 29);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(99, 23);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Logout \r\n";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblNameAndId
			// 
			this.lblNameAndId.AutoSize = true;
			this.lblNameAndId.ForeColor = System.Drawing.Color.White;
			this.lblNameAndId.Location = new System.Drawing.Point(15, 35);
			this.lblNameAndId.Name = "lblNameAndId";
			this.lblNameAndId.Size = new System.Drawing.Size(50, 12);
			this.lblNameAndId.TabIndex = 0;
			this.lblNameAndId.Text = "이름(ID)";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblLogo2);
			this.panel5.Controls.Add(this.lblLogo1);
			this.panel5.Location = new System.Drawing.Point(96, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(213, 78);
			this.panel5.TabIndex = 2;
			// 
			// lblLogo2
			// 
			this.lblLogo2.AutoSize = true;
			this.lblLogo2.ForeColor = System.Drawing.Color.White;
			this.lblLogo2.Location = new System.Drawing.Point(54, 45);
			this.lblLogo2.Name = "lblLogo2";
			this.lblLogo2.Size = new System.Drawing.Size(112, 12);
			this.lblLogo2.TabIndex = 0;
			this.lblLogo2.Text = "U N I V E R S I T Y\r\n";
			this.lblLogo2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblLogo1
			// 
			this.lblLogo1.AutoSize = true;
			this.lblLogo1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblLogo1.ForeColor = System.Drawing.Color.White;
			this.lblLogo1.Location = new System.Drawing.Point(43, 17);
			this.lblLogo1.Name = "lblLogo1";
			this.lblLogo1.Size = new System.Drawing.Size(133, 19);
			this.lblLogo1.TabIndex = 0;
			this.lblLogo1.Text = "KWANGWOON\r\n";
			this.lblLogo1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panelFooter);
			this.panel3.Location = new System.Drawing.Point(0, 655);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(996, 93);
			this.panel3.TabIndex = 2;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.IndianRed;
			this.panelFooter.Location = new System.Drawing.Point(0, 3);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(996, 87);
			this.panelFooter.TabIndex = 1;
			// 
			// lblCourseTime_Place
			// 
			this.lblCourseTime_Place.AutoSize = true;
			this.lblCourseTime_Place.Location = new System.Drawing.Point(330, 21);
			this.lblCourseTime_Place.Name = "lblCourseTime_Place";
			this.lblCourseTime_Place.Size = new System.Drawing.Size(59, 12);
			this.lblCourseTime_Place.TabIndex = 0;
			this.lblCourseTime_Place.Text = "날짜/주소";
			// 
			// lblCourseName_Id_lecturer
			// 
			this.lblCourseName_Id_lecturer.AutoSize = true;
			this.lblCourseName_Id_lecturer.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblCourseName_Id_lecturer.Location = new System.Drawing.Point(75, 18);
			this.lblCourseName_Id_lecturer.Name = "lblCourseName_Id_lecturer";
			this.lblCourseName_Id_lecturer.Size = new System.Drawing.Size(154, 15);
			this.lblCourseName_Id_lecturer.TabIndex = 0;
			this.lblCourseName_Id_lecturer.Text = "과목명(번호) - 교수";
			// 
			// panelMiddle2
			// 
			this.panelMiddle2.Controls.Add(this.label5);
			this.panelMiddle2.Controls.Add(this.dgvLectureNotice);
			this.panelMiddle2.Controls.Add(this.txtSearch);
			this.panelMiddle2.Controls.Add(this.btnTextSearch);
			this.panelMiddle2.Controls.Add(this.cbxSearchBased);
			this.panelMiddle2.Location = new System.Drawing.Point(-1, 206);
			this.panelMiddle2.Name = "panelMiddle2";
			this.panelMiddle2.Size = new System.Drawing.Size(997, 443);
			this.panelMiddle2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(69, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "공지사항";
			// 
			// dgvLectureNotice
			// 
			this.dgvLectureNotice.AutoGenerateColumns = false;
			this.dgvLectureNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLectureNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noticeIdDataGridViewTextBoxColumn,
            this.noticeTitleDataGridViewTextBoxColumn,
            this.noticeContentDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.noticeViewNumberDataGridViewTextBoxColumn});
			this.dgvLectureNotice.DataSource = this.lectureNoticeBindingSource;
			this.dgvLectureNotice.Location = new System.Drawing.Point(79, 84);
			this.dgvLectureNotice.Name = "dgvLectureNotice";
			this.dgvLectureNotice.RowTemplate.Height = 23;
			this.dgvLectureNotice.Size = new System.Drawing.Size(838, 333);
			this.dgvLectureNotice.TabIndex = 4;
			// 
			// noticeIdDataGridViewTextBoxColumn
			// 
			this.noticeIdDataGridViewTextBoxColumn.DataPropertyName = "NoticeId";
			this.noticeIdDataGridViewTextBoxColumn.HeaderText = "번호";
			this.noticeIdDataGridViewTextBoxColumn.Name = "noticeIdDataGridViewTextBoxColumn";
			this.noticeIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// noticeTitleDataGridViewTextBoxColumn
			// 
			this.noticeTitleDataGridViewTextBoxColumn.DataPropertyName = "NoticeTitle";
			this.noticeTitleDataGridViewTextBoxColumn.HeaderText = "제목";
			this.noticeTitleDataGridViewTextBoxColumn.Name = "noticeTitleDataGridViewTextBoxColumn";
			this.noticeTitleDataGridViewTextBoxColumn.Width = 240;
			// 
			// noticeContentDataGridViewTextBoxColumn
			// 
			this.noticeContentDataGridViewTextBoxColumn.DataPropertyName = "NoticeContent";
			this.noticeContentDataGridViewTextBoxColumn.HeaderText = "내용";
			this.noticeContentDataGridViewTextBoxColumn.Name = "noticeContentDataGridViewTextBoxColumn";
			this.noticeContentDataGridViewTextBoxColumn.Width = 155;
			// 
			// createdDateDataGridViewTextBoxColumn
			// 
			this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
			this.createdDateDataGridViewTextBoxColumn.HeaderText = "작성일";
			this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
			// 
			// createdByDataGridViewTextBoxColumn
			// 
			this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
			this.createdByDataGridViewTextBoxColumn.HeaderText = "작성자";
			this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
			// 
			// noticeViewNumberDataGridViewTextBoxColumn
			// 
			this.noticeViewNumberDataGridViewTextBoxColumn.DataPropertyName = "NoticeViewNumber";
			this.noticeViewNumberDataGridViewTextBoxColumn.HeaderText = "조회수";
			this.noticeViewNumberDataGridViewTextBoxColumn.Name = "noticeViewNumberDataGridViewTextBoxColumn";
			// 
			// lectureNoticeBindingSource
			// 
			this.lectureNoticeBindingSource.DataMember = "LectureNotice";
			this.lectureNoticeBindingSource.DataSource = this.kLAS_DBDataSet;
			// 
			// kLAS_DBDataSet
			// 
			this.kLAS_DBDataSet.DataSetName = "KLAS_DBDataSet";
			this.kLAS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(415, 46);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(205, 21);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnTextSearch
			// 
			this.btnTextSearch.Location = new System.Drawing.Point(626, 44);
			this.btnTextSearch.Name = "btnTextSearch";
			this.btnTextSearch.Size = new System.Drawing.Size(75, 23);
			this.btnTextSearch.TabIndex = 2;
			this.btnTextSearch.Text = "검색";
			this.btnTextSearch.UseVisualStyleBackColor = true;
			// 
			// cbxSearchBased
			// 
			this.cbxSearchBased.DisplayMember = "천제";
			this.cbxSearchBased.FormattingEnabled = true;
			this.cbxSearchBased.Items.AddRange(new object[] {
            "천제",
            "내용",
            "제목",
            "작성자"});
			this.cbxSearchBased.Location = new System.Drawing.Point(280, 46);
			this.cbxSearchBased.Name = "cbxSearchBased";
			this.cbxSearchBased.Size = new System.Drawing.Size(129, 20);
			this.cbxSearchBased.TabIndex = 1;
			this.cbxSearchBased.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxSearchBased_KeyDown);
			// 
			// panelMiddle1
			// 
			this.panelMiddle1.Controls.Add(this.lblCourseName_Id_lecturer);
			this.panelMiddle1.Controls.Add(this.lblCourseTime_Place);
			this.panelMiddle1.Controls.Add(this.comboBox1);
			this.panelMiddle1.Controls.Add(this.label3);
			this.panelMiddle1.Controls.Add(this.cbxCourseInfo);
			this.panelMiddle1.Controls.Add(this.label4);
			this.panelMiddle1.Location = new System.Drawing.Point(0, 88);
			this.panelMiddle1.Name = "panelMiddle1";
			this.panelMiddle1.Size = new System.Drawing.Size(996, 121);
			this.panelMiddle1.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(132, 74);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(129, 20);
			this.comboBox1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "수강학기";
			// 
			// cbxCourseInfo
			// 
			this.cbxCourseInfo.FormattingEnabled = true;
			this.cbxCourseInfo.Items.AddRange(new object[] {
            "알고리즘",
            "자료구조",
            "이산구조",
            "데이터베이스",
            "기계학습"});
			this.cbxCourseInfo.Location = new System.Drawing.Point(710, 69);
			this.cbxCourseInfo.Name = "cbxCourseInfo";
			this.cbxCourseInfo.Size = new System.Drawing.Size(206, 20);
			this.cbxCourseInfo.TabIndex = 1;
			this.cbxCourseInfo.SelectedIndexChanged += new System.EventHandler(this.cbxCourseInfo_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(659, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "과목명";
			// 
			// lectureNoticeTableAdapter
			// 
			this.lectureNoticeTableAdapter.ClearBeforeFill = true;
			// 
			// sfLectureNotices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 743);
			this.Controls.Add(this.panelMiddle1);
			this.Controls.Add(this.panelMiddle2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "sfLectureNotices";
			this.Text = "sfLectureNotices";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sfLectureNotices_FormClosed);
			this.Load += new System.EventHandler(this.sfLectureNotices_Load);
			this.panel1.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panelMiddle2.ResumeLayout(false);
			this.panelMiddle2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoticeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet)).EndInit();
			this.panelMiddle1.ResumeLayout(false);
			this.panelMiddle1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Footer panelFooter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.ComboBox cbxMenu;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblNameAndId;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblLogo2;
		private System.Windows.Forms.Label lblLogo1;
		private System.Windows.Forms.Label lblCourseTime_Place;
		private System.Windows.Forms.Label lblCourseName_Id_lecturer;
		private System.Windows.Forms.Panel panelMiddle2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvLectureNotice;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnTextSearch;
		private System.Windows.Forms.ComboBox cbxSearchBased;
		private System.Windows.Forms.Panel panelMiddle1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxCourseInfo;
		private System.Windows.Forms.Label label4;
		private KLAS_DBDataSet kLAS_DBDataSet;
		private System.Windows.Forms.BindingSource lectureNoticeBindingSource;
		private KLAS_DBDataSetTableAdapters.LectureNoticeTableAdapter lectureNoticeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeContentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeViewNumberDataGridViewTextBoxColumn;
	}
}