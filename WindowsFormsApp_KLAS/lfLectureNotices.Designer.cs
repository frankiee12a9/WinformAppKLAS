
namespace WindowsFormsApp_KLAS
{
	partial class lfLectureNotices
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.cbxSemester = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCourses = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelMiddle = new System.Windows.Forms.Panel();
			this.dgvLectureNotices = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnNoticeChange = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbxSearch = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panelCrud = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCourseId = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.txtLecturerId = new System.Windows.Forms.TextBox();
			this.txtLecturer = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.btnCrudInsert = new System.Windows.Forms.Button();
			this.btnCrudCancel = new System.Windows.Forms.Button();
			this.btnCrudDel = new System.Windows.Forms.Button();
			this.btnCrudUpdate = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbxMenu = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblNameAndId = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.kLAS_DBDataSet3 = new WindowsFormsApp_KLAS.KLAS_DBDataSet3();
			this.lectureNoticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lectureNoticeTableAdapter = new WindowsFormsApp_KLAS.KLAS_DBDataSet3TableAdapters.LectureNoticeTableAdapter();
			this.noticeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noticeViewNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelFooter = new WindowsFormsApp_KLAS.Footer();
			this.panelHeader.SuspendLayout();
			this.panelMiddle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotices)).BeginInit();
			this.panelCrud.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoticeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.Controls.Add(this.cbxSemester);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Controls.Add(this.cbxCourses);
			this.panelHeader.Controls.Add(this.label2);
			this.panelHeader.Location = new System.Drawing.Point(1, 96);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(981, 59);
			this.panelHeader.TabIndex = 1;
			// 
			// cbxSemester
			// 
			this.cbxSemester.FormattingEnabled = true;
			this.cbxSemester.Items.AddRange(new object[] {
            "2021년도 1학기"});
			this.cbxSemester.Location = new System.Drawing.Point(122, 24);
			this.cbxSemester.Name = "cbxSemester";
			this.cbxSemester.Size = new System.Drawing.Size(129, 20);
			this.cbxSemester.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "수강학기";
			// 
			// cbxCourses
			// 
			this.cbxCourses.FormattingEnabled = true;
			this.cbxCourses.Location = new System.Drawing.Point(727, 21);
			this.cbxCourses.Name = "cbxCourses";
			this.cbxCourses.Size = new System.Drawing.Size(160, 20);
			this.cbxCourses.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(647, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "과목명";
			// 
			// panelMiddle
			// 
			this.panelMiddle.Controls.Add(this.dgvLectureNotices);
			this.panelMiddle.Controls.Add(this.txtSearch);
			this.panelMiddle.Controls.Add(this.btnNoticeChange);
			this.panelMiddle.Controls.Add(this.btnSearch);
			this.panelMiddle.Controls.Add(this.cbxSearch);
			this.panelMiddle.Controls.Add(this.label3);
			this.panelMiddle.Location = new System.Drawing.Point(1, 161);
			this.panelMiddle.Name = "panelMiddle";
			this.panelMiddle.Size = new System.Drawing.Size(981, 273);
			this.panelMiddle.TabIndex = 2;
			// 
			// dgvLectureNotices
			// 
			this.dgvLectureNotices.AutoGenerateColumns = false;
			this.dgvLectureNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLectureNotices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noticeIdDataGridViewTextBoxColumn,
            this.noticeTitleDataGridViewTextBoxColumn,
            this.noticeContentDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn,
            this.noticeViewNumberDataGridViewTextBoxColumn});
			this.dgvLectureNotices.DataSource = this.lectureNoticeBindingSource;
			this.dgvLectureNotices.Location = new System.Drawing.Point(75, 74);
			this.dgvLectureNotices.Name = "dgvLectureNotices";
			this.dgvLectureNotices.RowTemplate.Height = 23;
			this.dgvLectureNotices.Size = new System.Drawing.Size(812, 187);
			this.dgvLectureNotices.TabIndex = 4;
			this.dgvLectureNotices.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLectureNotices_CellContentDoubleClick);
			this.dgvLectureNotices.DoubleClick += new System.EventHandler(this.dgvLectureNotices_DoubleClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(421, 38);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(205, 21);
			this.txtSearch.TabIndex = 3;
			// 
			// btnNoticeChange
			// 
			this.btnNoticeChange.Location = new System.Drawing.Point(893, 223);
			this.btnNoticeChange.Name = "btnNoticeChange";
			this.btnNoticeChange.Size = new System.Drawing.Size(59, 38);
			this.btnNoticeChange.TabIndex = 2;
			this.btnNoticeChange.Text = "수정";
			this.btnNoticeChange.UseVisualStyleBackColor = true;
			this.btnNoticeChange.Click += new System.EventHandler(this.btnNoticeChange_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(632, 36);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// cbxSearch
			// 
			this.cbxSearch.FormattingEnabled = true;
			this.cbxSearch.Items.AddRange(new object[] {
            "전체 ",
            "체목",
            "내용 ",
            "작성자 "});
			this.cbxSearch.Location = new System.Drawing.Point(286, 38);
			this.cbxSearch.Name = "cbxSearch";
			this.cbxSearch.Size = new System.Drawing.Size(129, 20);
			this.cbxSearch.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(62, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "강의 공지사항";
			// 
			// panelCrud
			// 
			this.panelCrud.Controls.Add(this.label11);
			this.panelCrud.Controls.Add(this.label10);
			this.panelCrud.Controls.Add(this.label8);
			this.panelCrud.Controls.Add(this.label7);
			this.panelCrud.Controls.Add(this.label5);
			this.panelCrud.Controls.Add(this.label9);
			this.panelCrud.Controls.Add(this.label4);
			this.panelCrud.Controls.Add(this.txtCourseId);
			this.panelCrud.Controls.Add(this.textBox6);
			this.panelCrud.Controls.Add(this.txtLecturerId);
			this.panelCrud.Controls.Add(this.txtLecturer);
			this.panelCrud.Controls.Add(this.txtContent);
			this.panelCrud.Controls.Add(this.txtTitle);
			this.panelCrud.Controls.Add(this.btnCrudInsert);
			this.panelCrud.Controls.Add(this.btnCrudCancel);
			this.panelCrud.Controls.Add(this.btnCrudDel);
			this.panelCrud.Controls.Add(this.btnCrudUpdate);
			this.panelCrud.Location = new System.Drawing.Point(1, 440);
			this.panelCrud.Name = "panelCrud";
			this.panelCrud.Size = new System.Drawing.Size(981, 234);
			this.panelCrud.TabIndex = 3;
			this.panelCrud.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCrud_Paint);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(46, 196);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "과목 번호";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(49, 196);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 12);
			this.label10.TabIndex = 0;
			this.label10.Text = "작성자 번호";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(46, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "작성자 번호";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(49, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 0;
			this.label7.Text = "작성자";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "제목";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(419, 117);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "내용";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(410, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "공지사항 수정";
			// 
			// txtCourseId
			// 
			this.txtCourseId.Location = new System.Drawing.Point(138, 193);
			this.txtCourseId.Name = "txtCourseId";
			this.txtCourseId.Size = new System.Drawing.Size(205, 21);
			this.txtCourseId.TabIndex = 3;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(138, 193);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(205, 21);
			this.textBox6.TabIndex = 3;
			// 
			// txtLecturerId
			// 
			this.txtLecturerId.Location = new System.Drawing.Point(138, 147);
			this.txtLecturerId.Name = "txtLecturerId";
			this.txtLecturerId.Size = new System.Drawing.Size(205, 21);
			this.txtLecturerId.TabIndex = 3;
			// 
			// txtLecturer
			// 
			this.txtLecturer.Location = new System.Drawing.Point(138, 96);
			this.txtLecturer.Name = "txtLecturer";
			this.txtLecturer.Size = new System.Drawing.Size(205, 21);
			this.txtLecturer.TabIndex = 3;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(483, 50);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(296, 164);
			this.txtContent.TabIndex = 3;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(138, 48);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(205, 21);
			this.txtTitle.TabIndex = 3;
			// 
			// btnCrudInsert
			// 
			this.btnCrudInsert.Location = new System.Drawing.Point(808, 137);
			this.btnCrudInsert.Name = "btnCrudInsert";
			this.btnCrudInsert.Size = new System.Drawing.Size(79, 31);
			this.btnCrudInsert.TabIndex = 2;
			this.btnCrudInsert.Text = "올리기";
			this.btnCrudInsert.UseVisualStyleBackColor = true;
			this.btnCrudInsert.Click += new System.EventHandler(this.btnCrudInsert_Click);
			// 
			// btnCrudCancel
			// 
			this.btnCrudCancel.Location = new System.Drawing.Point(808, 183);
			this.btnCrudCancel.Name = "btnCrudCancel";
			this.btnCrudCancel.Size = new System.Drawing.Size(79, 31);
			this.btnCrudCancel.TabIndex = 2;
			this.btnCrudCancel.Text = "취소";
			this.btnCrudCancel.UseVisualStyleBackColor = true;
			this.btnCrudCancel.Click += new System.EventHandler(this.btnCrudCancel_Click);
			// 
			// btnCrudDel
			// 
			this.btnCrudDel.Location = new System.Drawing.Point(808, 90);
			this.btnCrudDel.Name = "btnCrudDel";
			this.btnCrudDel.Size = new System.Drawing.Size(79, 31);
			this.btnCrudDel.TabIndex = 2;
			this.btnCrudDel.Text = "삭제";
			this.btnCrudDel.UseVisualStyleBackColor = true;
			this.btnCrudDel.Click += new System.EventHandler(this.btnCrudDel_Click);
			// 
			// btnCrudUpdate
			// 
			this.btnCrudUpdate.Location = new System.Drawing.Point(808, 48);
			this.btnCrudUpdate.Name = "btnCrudUpdate";
			this.btnCrudUpdate.Size = new System.Drawing.Size(79, 31);
			this.btnCrudUpdate.TabIndex = 2;
			this.btnCrudUpdate.Text = "저장";
			this.btnCrudUpdate.UseVisualStyleBackColor = true;
			this.btnCrudUpdate.Click += new System.EventHandler(this.btnCrudUpdate_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelFooter);
			this.panel1.Location = new System.Drawing.Point(3, 680);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(979, 90);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(3, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(979, 90);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.IndianRed;
			this.panel3.Controls.Add(this.cbxMenu);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Location = new System.Drawing.Point(-2, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(981, 84);
			this.panel3.TabIndex = 2;
			// 
			// cbxMenu
			// 
			this.cbxMenu.FormattingEnabled = true;
			this.cbxMenu.Items.AddRange(new object[] {
            "Lecture Notes",
            "Lecture Notices",
            "Lecture Syllabus"});
			this.cbxMenu.Location = new System.Drawing.Point(315, 31);
			this.cbxMenu.Name = "cbxMenu";
			this.cbxMenu.Size = new System.Drawing.Size(121, 20);
			this.cbxMenu.TabIndex = 4;
			this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnLogout);
			this.panel4.Controls.Add(this.lblNameAndId);
			this.panel4.Location = new System.Drawing.Point(588, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(393, 78);
			this.panel4.TabIndex = 3;
			// 
			// btnLogout
			// 
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogout.Location = new System.Drawing.Point(181, 29);
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
			this.lblNameAndId.Location = new System.Drawing.Point(36, 34);
			this.lblNameAndId.Name = "lblNameAndId";
			this.lblNameAndId.Size = new System.Drawing.Size(50, 12);
			this.lblNameAndId.TabIndex = 0;
			this.lblNameAndId.Text = "이름(ID)";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Location = new System.Drawing.Point(96, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(213, 78);
			this.panel5.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(54, 45);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 12);
			this.label12.TabIndex = 0;
			this.label12.Text = "U N I V E R S I T Y\r\n";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(43, 17);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(133, 19);
			this.label13.TabIndex = 0;
			this.label13.Text = "KWANGWOON\r\n";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// kLAS_DBDataSet3
			// 
			this.kLAS_DBDataSet3.DataSetName = "KLAS_DBDataSet3";
			this.kLAS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lectureNoticeBindingSource
			// 
			this.lectureNoticeBindingSource.DataMember = "LectureNotice";
			this.lectureNoticeBindingSource.DataSource = this.kLAS_DBDataSet3;
			// 
			// lectureNoticeTableAdapter
			// 
			this.lectureNoticeTableAdapter.ClearBeforeFill = true;
			// 
			// noticeIdDataGridViewTextBoxColumn
			// 
			this.noticeIdDataGridViewTextBoxColumn.DataPropertyName = "NoticeId";
			this.noticeIdDataGridViewTextBoxColumn.HeaderText = "번호";
			this.noticeIdDataGridViewTextBoxColumn.Name = "noticeIdDataGridViewTextBoxColumn";
			this.noticeIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.noticeIdDataGridViewTextBoxColumn.Width = 80;
			// 
			// noticeTitleDataGridViewTextBoxColumn
			// 
			this.noticeTitleDataGridViewTextBoxColumn.DataPropertyName = "NoticeTitle";
			this.noticeTitleDataGridViewTextBoxColumn.HeaderText = "제목";
			this.noticeTitleDataGridViewTextBoxColumn.Name = "noticeTitleDataGridViewTextBoxColumn";
			this.noticeTitleDataGridViewTextBoxColumn.Width = 150;
			// 
			// noticeContentDataGridViewTextBoxColumn
			// 
			this.noticeContentDataGridViewTextBoxColumn.DataPropertyName = "NoticeContent";
			this.noticeContentDataGridViewTextBoxColumn.HeaderText = "내용";
			this.noticeContentDataGridViewTextBoxColumn.Name = "noticeContentDataGridViewTextBoxColumn";
			this.noticeContentDataGridViewTextBoxColumn.Width = 160;
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
			// courseIdDataGridViewTextBoxColumn
			// 
			this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
			this.courseIdDataGridViewTextBoxColumn.HeaderText = "과목번호";
			this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
			// 
			// noticeViewNumberDataGridViewTextBoxColumn
			// 
			this.noticeViewNumberDataGridViewTextBoxColumn.DataPropertyName = "NoticeViewNumber";
			this.noticeViewNumberDataGridViewTextBoxColumn.HeaderText = "조회수";
			this.noticeViewNumberDataGridViewTextBoxColumn.Name = "noticeViewNumberDataGridViewTextBoxColumn";
			this.noticeViewNumberDataGridViewTextBoxColumn.Width = 80;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.IndianRed;
			this.panelFooter.Location = new System.Drawing.Point(-12, 4);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(991, 86);
			this.panelFooter.TabIndex = 2;
			// 
			// lfLectureNotices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 768);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelCrud);
			this.Controls.Add(this.panelMiddle);
			this.Controls.Add(this.panelHeader);
			this.Name = "lfLectureNotices";
			this.Text = "fLectureNotices";
			this.Load += new System.EventHandler(this.lfLectureNotices_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelMiddle.ResumeLayout(false);
			this.panelMiddle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotices)).EndInit();
			this.panelCrud.ResumeLayout(false);
			this.panelCrud.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoticeBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.ComboBox cbxSemester;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxCourses;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelMiddle;
		private System.Windows.Forms.DataGridView dgvLectureNotices;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnNoticeChange;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbxSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelCrud;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLecturerId;
		private System.Windows.Forms.TextBox txtLecturer;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Button btnCrudCancel;
		private System.Windows.Forms.Button btnCrudDel;
		private System.Windows.Forms.Button btnCrudUpdate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCourseId;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cbxMenu;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblNameAndId;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private Footer panelFooter;
		private System.Windows.Forms.Button btnCrudInsert;
		private System.Windows.Forms.TextBox txtContent;
		private KLAS_DBDataSet3 kLAS_DBDataSet3;
		private System.Windows.Forms.BindingSource lectureNoticeBindingSource;
		private KLAS_DBDataSet3TableAdapters.LectureNoticeTableAdapter lectureNoticeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeContentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noticeViewNumberDataGridViewTextBoxColumn;
	}
}