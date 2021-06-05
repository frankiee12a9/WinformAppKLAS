
namespace WindowsFormsApp_KLAS
{
	partial class lfLectureNotes
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
			this.panelMiddle2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvLectureNotes = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnNotesChange = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cvxSearchBased = new System.Windows.Forms.ComboBox();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.cbxMenu = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblNameAndId = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblLogo2 = new System.Windows.Forms.Label();
			this.lblLogo1 = new System.Windows.Forms.Label();
			this.panelFooter = new WindowsFormsApp_KLAS.Footer();
			this.panelMiddle1 = new System.Windows.Forms.Panel();
			this.cbxSemester = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCourses = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelCrud = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
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
			this.kLAS_DBDataSet1 = new WindowsFormsApp_KLAS.KLAS_DBDataSet1();
			this.kLASDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kLAS_DBDataSet2 = new WindowsFormsApp_KLAS.KLAS_DBDataSet2();
			this.lectureNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lectureNoteTableAdapter = new WindowsFormsApp_KLAS.KLAS_DBDataSet2TableAdapters.LectureNoteTableAdapter();
			this.noteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteViewsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelMiddle2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotes)).BeginInit();
			this.panelHeader.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panelMiddle1.SuspendLayout();
			this.panelCrud.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kLASDBDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMiddle2
			// 
			this.panelMiddle2.Controls.Add(this.label3);
			this.panelMiddle2.Controls.Add(this.dgvLectureNotes);
			this.panelMiddle2.Controls.Add(this.txtSearch);
			this.panelMiddle2.Controls.Add(this.btnNotesChange);
			this.panelMiddle2.Controls.Add(this.btnSearch);
			this.panelMiddle2.Controls.Add(this.cvxSearchBased);
			this.panelMiddle2.Location = new System.Drawing.Point(0, 161);
			this.panelMiddle2.Name = "panelMiddle2";
			this.panelMiddle2.Size = new System.Drawing.Size(981, 271);
			this.panelMiddle2.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(71, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "강의 자료실";
			// 
			// dgvLectureNotes
			// 
			this.dgvLectureNotes.AutoGenerateColumns = false;
			this.dgvLectureNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLectureNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteIdDataGridViewTextBoxColumn,
            this.noteTitleDataGridViewTextBoxColumn,
            this.noteContentDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn,
            this.noteViewsNumberDataGridViewTextBoxColumn});
			this.dgvLectureNotes.DataSource = this.lectureNoteBindingSource;
			this.dgvLectureNotes.Location = new System.Drawing.Point(75, 64);
			this.dgvLectureNotes.Name = "dgvLectureNotes";
			this.dgvLectureNotes.RowTemplate.Height = 23;
			this.dgvLectureNotes.Size = new System.Drawing.Size(812, 198);
			this.dgvLectureNotes.TabIndex = 4;
			this.dgvLectureNotes.DoubleClick += new System.EventHandler(this.dgvLectureNotes_DoubleClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(421, 36);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(205, 21);
			this.txtSearch.TabIndex = 3;
			// 
			// btnNotesChange
			// 
			this.btnNotesChange.Location = new System.Drawing.Point(893, 225);
			this.btnNotesChange.Name = "btnNotesChange";
			this.btnNotesChange.Size = new System.Drawing.Size(66, 37);
			this.btnNotesChange.TabIndex = 2;
			this.btnNotesChange.Text = "수정";
			this.btnNotesChange.UseVisualStyleBackColor = true;
			this.btnNotesChange.Click += new System.EventHandler(this.btnNotesChange_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(632, 35);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// cvxSearchBased
			// 
			this.cvxSearchBased.FormattingEnabled = true;
			this.cvxSearchBased.Location = new System.Drawing.Point(286, 36);
			this.cvxSearchBased.Name = "cvxSearchBased";
			this.cvxSearchBased.Size = new System.Drawing.Size(129, 20);
			this.cvxSearchBased.TabIndex = 1;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.IndianRed;
			this.panelHeader.Controls.Add(this.cbxMenu);
			this.panelHeader.Controls.Add(this.panel4);
			this.panelHeader.Controls.Add(this.panel5);
			this.panelHeader.Location = new System.Drawing.Point(0, -5);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(999, 88);
			this.panelHeader.TabIndex = 2;
			// 
			// cbxMenu
			// 
			this.cbxMenu.FormattingEnabled = true;
			this.cbxMenu.Items.AddRange(new object[] {
            "공지사항",
            "강의자료실",
            "강의계획서"});
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
			this.panel4.Location = new System.Drawing.Point(711, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(279, 78);
			this.panel4.TabIndex = 3;
			// 
			// btnLogout
			// 
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogout.Location = new System.Drawing.Point(167, 29);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(90, 23);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Logout \r\n";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblNameAndId
			// 
			this.lblNameAndId.AutoSize = true;
			this.lblNameAndId.ForeColor = System.Drawing.Color.White;
			this.lblNameAndId.Location = new System.Drawing.Point(20, 34);
			this.lblNameAndId.Name = "lblNameAndId";
			this.lblNameAndId.Size = new System.Drawing.Size(50, 12);
			this.lblNameAndId.TabIndex = 0;
			this.lblNameAndId.Text = "이름(ID)";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblLogo2);
			this.panel5.Controls.Add(this.lblLogo1);
			this.panel5.Location = new System.Drawing.Point(96, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(213, 82);
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
			this.lblLogo2.Click += new System.EventHandler(this.lblLogo2_Click);
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
			this.lblLogo1.Click += new System.EventHandler(this.lblLogo1_Click);
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.IndianRed;
			this.panelFooter.Location = new System.Drawing.Point(-3, 674);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(984, 92);
			this.panelFooter.TabIndex = 3;
			// 
			// panelMiddle1
			// 
			this.panelMiddle1.Controls.Add(this.cbxSemester);
			this.panelMiddle1.Controls.Add(this.label1);
			this.panelMiddle1.Controls.Add(this.cbxCourses);
			this.panelMiddle1.Controls.Add(this.label2);
			this.panelMiddle1.Location = new System.Drawing.Point(0, 89);
			this.panelMiddle1.Name = "panelMiddle1";
			this.panelMiddle1.Size = new System.Drawing.Size(981, 66);
			this.panelMiddle1.TabIndex = 4;
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
			// panelCrud
			// 
			this.panelCrud.Controls.Add(this.label4);
			this.panelCrud.Controls.Add(this.label5);
			this.panelCrud.Controls.Add(this.label8);
			this.panelCrud.Controls.Add(this.label7);
			this.panelCrud.Controls.Add(this.label6);
			this.panelCrud.Controls.Add(this.label9);
			this.panelCrud.Controls.Add(this.label12);
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
			this.panelCrud.Location = new System.Drawing.Point(0, 438);
			this.panelCrud.Name = "panelCrud";
			this.panelCrud.Size = new System.Drawing.Size(981, 240);
			this.panelCrud.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "과목 번호";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "작성자 번호";
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(49, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "제목";
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
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(410, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(139, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "강의 자료실 수정";
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
			this.btnCrudInsert.Location = new System.Drawing.Point(808, 141);
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
			// kLAS_DBDataSet1
			// 
			this.kLAS_DBDataSet1.DataSetName = "KLAS_DBDataSet1";
			this.kLAS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kLASDBDataSet1BindingSource
			// 
			this.kLASDBDataSet1BindingSource.DataSource = this.kLAS_DBDataSet1;
			this.kLASDBDataSet1BindingSource.Position = 0;
			// 
			// kLAS_DBDataSet2
			// 
			this.kLAS_DBDataSet2.DataSetName = "KLAS_DBDataSet2";
			this.kLAS_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lectureNoteBindingSource
			// 
			this.lectureNoteBindingSource.DataMember = "LectureNote";
			this.lectureNoteBindingSource.DataSource = this.kLAS_DBDataSet2;
			// 
			// lectureNoteTableAdapter
			// 
			this.lectureNoteTableAdapter.ClearBeforeFill = true;
			// 
			// noteIdDataGridViewTextBoxColumn
			// 
			this.noteIdDataGridViewTextBoxColumn.DataPropertyName = "NoteId";
			this.noteIdDataGridViewTextBoxColumn.HeaderText = "번호";
			this.noteIdDataGridViewTextBoxColumn.Name = "noteIdDataGridViewTextBoxColumn";
			this.noteIdDataGridViewTextBoxColumn.Width = 80;
			// 
			// noteTitleDataGridViewTextBoxColumn
			// 
			this.noteTitleDataGridViewTextBoxColumn.DataPropertyName = "NoteTitle";
			this.noteTitleDataGridViewTextBoxColumn.HeaderText = "제목";
			this.noteTitleDataGridViewTextBoxColumn.Name = "noteTitleDataGridViewTextBoxColumn";
			this.noteTitleDataGridViewTextBoxColumn.Width = 150;
			// 
			// noteContentDataGridViewTextBoxColumn
			// 
			this.noteContentDataGridViewTextBoxColumn.DataPropertyName = "NoteContent";
			this.noteContentDataGridViewTextBoxColumn.HeaderText = "내용";
			this.noteContentDataGridViewTextBoxColumn.Name = "noteContentDataGridViewTextBoxColumn";
			this.noteContentDataGridViewTextBoxColumn.Width = 150;
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
			this.courseIdDataGridViewTextBoxColumn.HeaderText = "과목 번호";
			this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
			// 
			// noteViewsNumberDataGridViewTextBoxColumn
			// 
			this.noteViewsNumberDataGridViewTextBoxColumn.DataPropertyName = "NoteViewsNumber";
			this.noteViewsNumberDataGridViewTextBoxColumn.HeaderText = "조회수";
			this.noteViewsNumberDataGridViewTextBoxColumn.Name = "noteViewsNumberDataGridViewTextBoxColumn";
			// 
			// lfLectureNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 762);
			this.Controls.Add(this.panelCrud);
			this.Controls.Add(this.panelMiddle1);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelMiddle2);
			this.Name = "lfLectureNotes";
			this.Text = "fLectureNotes";
			this.Load += new System.EventHandler(this.fLectureNotes_Load);
			this.panelMiddle2.ResumeLayout(false);
			this.panelMiddle2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotes)).EndInit();
			this.panelHeader.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panelMiddle1.ResumeLayout(false);
			this.panelMiddle1.PerformLayout();
			this.panelCrud.ResumeLayout(false);
			this.panelCrud.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kLASDBDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMiddle2;
		private System.Windows.Forms.DataGridView dgvLectureNotes;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnNotesChange;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cvxSearchBased;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.ComboBox cbxMenu;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblNameAndId;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblLogo2;
		private System.Windows.Forms.Label lblLogo1;
		private Footer panelFooter;
		private System.Windows.Forms.Panel panelMiddle1;
		private System.Windows.Forms.ComboBox cbxSemester;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxCourses;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelCrud;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCourseId;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox txtLecturerId;
		private System.Windows.Forms.TextBox txtLecturer;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Button btnCrudInsert;
		private System.Windows.Forms.Button btnCrudCancel;
		private System.Windows.Forms.Button btnCrudDel;
		private System.Windows.Forms.Button btnCrudUpdate;
		private KLAS_DBDataSet1 kLAS_DBDataSet1;
		private System.Windows.Forms.BindingSource kLASDBDataSet1BindingSource;
		private KLAS_DBDataSet2 kLAS_DBDataSet2;
		private System.Windows.Forms.BindingSource lectureNoteBindingSource;
		private KLAS_DBDataSet2TableAdapters.LectureNoteTableAdapter lectureNoteTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteViewsNumberDataGridViewTextBoxColumn;
	}
}