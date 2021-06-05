
namespace WindowsFormsApp_KLAS
{
	partial class sfLectureNotes
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblCourseTime_Place = new System.Windows.Forms.Label();
			this.lblCourseName_Id_lecturer = new System.Windows.Forms.Label();
			this.panelMiddle2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvLectureNotes = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbxSearchBased = new System.Windows.Forms.ComboBox();
			this.panelMiddle1 = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxSelectCourse = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panelFooter = new WindowsFormsApp_KLAS.Footer();
			this.kLAS_DBDataSet1 = new WindowsFormsApp_KLAS.KLAS_DBDataSet1();
			this.lectureNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lectureNoteTableAdapter = new WindowsFormsApp_KLAS.KLAS_DBDataSet1TableAdapters.LectureNoteTableAdapter();
			this.noteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteViewsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelMiddle2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotes)).BeginInit();
			this.panelMiddle1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelHeader);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1038, 85);
			this.panel1.TabIndex = 0;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.IndianRed;
			this.panelHeader.Controls.Add(this.cbxMenu);
			this.panelHeader.Controls.Add(this.panel4);
			this.panelHeader.Controls.Add(this.panel5);
			this.panelHeader.Location = new System.Drawing.Point(3, 3);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(981, 82);
			this.panelHeader.TabIndex = 1;
			// 
			// cbxMenu
			// 
			this.cbxMenu.FormattingEnabled = true;
			this.cbxMenu.Items.AddRange(new object[] {
            "공지사항",
            "강의자료실",
            "강의계획서"});
			this.cbxMenu.Location = new System.Drawing.Point(315, 29);
			this.cbxMenu.Name = "cbxMenu";
			this.cbxMenu.Size = new System.Drawing.Size(121, 20);
			this.cbxMenu.TabIndex = 4;
			this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnLogout);
			this.panel4.Controls.Add(this.lblNameAndId);
			this.panel4.Location = new System.Drawing.Point(720, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(279, 78);
			this.panel4.TabIndex = 3;
			// 
			// btnLogout
			// 
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogout.Location = new System.Drawing.Point(152, 27);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(87, 23);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Logout \r\n";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblNameAndId
			// 
			this.lblNameAndId.AutoSize = true;
			this.lblNameAndId.ForeColor = System.Drawing.Color.White;
			this.lblNameAndId.Location = new System.Drawing.Point(12, 34);
			this.lblNameAndId.Name = "lblNameAndId";
			this.lblNameAndId.Size = new System.Drawing.Size(50, 12);
			this.lblNameAndId.TabIndex = 0;
			this.lblNameAndId.Text = "이름(ID)";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Location = new System.Drawing.Point(96, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(213, 78);
			this.panel5.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(54, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "U N I V E R S I T Y\r\n";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(43, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "KWANGWOON\r\n";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panelMiddle2);
			this.panel2.Controls.Add(this.panelMiddle1);
			this.panel2.Location = new System.Drawing.Point(0, 91);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(980, 585);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lblCourseTime_Place);
			this.panel3.Controls.Add(this.lblCourseName_Id_lecturer);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(980, 51);
			this.panel3.TabIndex = 7;
			// 
			// lblCourseTime_Place
			// 
			this.lblCourseTime_Place.AutoSize = true;
			this.lblCourseTime_Place.Location = new System.Drawing.Point(316, 21);
			this.lblCourseTime_Place.Name = "lblCourseTime_Place";
			this.lblCourseTime_Place.Size = new System.Drawing.Size(59, 12);
			this.lblCourseTime_Place.TabIndex = 0;
			this.lblCourseTime_Place.Text = "날짜/주소";
			// 
			// lblCourseName_Id_lecturer
			// 
			this.lblCourseName_Id_lecturer.AutoSize = true;
			this.lblCourseName_Id_lecturer.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblCourseName_Id_lecturer.Location = new System.Drawing.Point(75, 21);
			this.lblCourseName_Id_lecturer.Name = "lblCourseName_Id_lecturer";
			this.lblCourseName_Id_lecturer.Size = new System.Drawing.Size(101, 15);
			this.lblCourseName_Id_lecturer.TabIndex = 0;
			this.lblCourseName_Id_lecturer.Text = "과목명(번호)";
			// 
			// panelMiddle2
			// 
			this.panelMiddle2.Controls.Add(this.label5);
			this.panelMiddle2.Controls.Add(this.dgvLectureNotes);
			this.panelMiddle2.Controls.Add(this.txtSearch);
			this.panelMiddle2.Controls.Add(this.btnSearch);
			this.panelMiddle2.Controls.Add(this.cbxSearchBased);
			this.panelMiddle2.Location = new System.Drawing.Point(3, 132);
			this.panelMiddle2.Name = "panelMiddle2";
			this.panelMiddle2.Size = new System.Drawing.Size(981, 450);
			this.panelMiddle2.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(70, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "강의 자료실";
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
            this.noteViewsNumberDataGridViewTextBoxColumn});
			this.dgvLectureNotes.DataSource = this.lectureNoteBindingSource;
			this.dgvLectureNotes.Location = new System.Drawing.Point(75, 76);
			this.dgvLectureNotes.Name = "dgvLectureNotes";
			this.dgvLectureNotes.RowTemplate.Height = 23;
			this.dgvLectureNotes.Size = new System.Drawing.Size(824, 333);
			this.dgvLectureNotes.TabIndex = 4;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(416, 36);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(205, 21);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(627, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// cbxSearchBased
			// 
			this.cbxSearchBased.FormattingEnabled = true;
			this.cbxSearchBased.Items.AddRange(new object[] {
            "천제",
            "내용",
            "제목",
            "작성자"});
			this.cbxSearchBased.Location = new System.Drawing.Point(281, 36);
			this.cbxSearchBased.Name = "cbxSearchBased";
			this.cbxSearchBased.Size = new System.Drawing.Size(129, 20);
			this.cbxSearchBased.TabIndex = 1;
			// 
			// panelMiddle1
			// 
			this.panelMiddle1.Controls.Add(this.comboBox1);
			this.panelMiddle1.Controls.Add(this.label3);
			this.panelMiddle1.Controls.Add(this.cbxSelectCourse);
			this.panelMiddle1.Controls.Add(this.label4);
			this.panelMiddle1.Location = new System.Drawing.Point(3, 57);
			this.panelMiddle1.Name = "panelMiddle1";
			this.panelMiddle1.Size = new System.Drawing.Size(981, 69);
			this.panelMiddle1.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(122, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(129, 20);
			this.comboBox1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "수강학기";
			// 
			// cbxSelectCourse
			// 
			this.cbxSelectCourse.FormattingEnabled = true;
			this.cbxSelectCourse.Items.AddRange(new object[] {
            "알고리즘",
            "자료구조",
            "이산구조",
            "데이터베이스",
            "기계학습"});
			this.cbxSelectCourse.Location = new System.Drawing.Point(709, 21);
			this.cbxSelectCourse.Name = "cbxSelectCourse";
			this.cbxSelectCourse.Size = new System.Drawing.Size(190, 20);
			this.cbxSelectCourse.TabIndex = 1;
			this.cbxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cbxSelectCourse_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(649, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "과목명";
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.IndianRed;
			this.panelFooter.Location = new System.Drawing.Point(0, 682);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(980, 78);
			this.panelFooter.TabIndex = 1;
			// 
			// kLAS_DBDataSet1
			// 
			this.kLAS_DBDataSet1.DataSetName = "KLAS_DBDataSet1";
			this.kLAS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lectureNoteBindingSource
			// 
			this.lectureNoteBindingSource.DataMember = "LectureNote";
			this.lectureNoteBindingSource.DataSource = this.kLAS_DBDataSet1;
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
			this.noteIdDataGridViewTextBoxColumn.Width = 90;
			// 
			// noteTitleDataGridViewTextBoxColumn
			// 
			this.noteTitleDataGridViewTextBoxColumn.DataPropertyName = "NoteTitle";
			this.noteTitleDataGridViewTextBoxColumn.HeaderText = "제목";
			this.noteTitleDataGridViewTextBoxColumn.Name = "noteTitleDataGridViewTextBoxColumn";
			this.noteTitleDataGridViewTextBoxColumn.Width = 180;
			// 
			// noteContentDataGridViewTextBoxColumn
			// 
			this.noteContentDataGridViewTextBoxColumn.DataPropertyName = "NoteContent";
			this.noteContentDataGridViewTextBoxColumn.HeaderText = "내용";
			this.noteContentDataGridViewTextBoxColumn.Name = "noteContentDataGridViewTextBoxColumn";
			this.noteContentDataGridViewTextBoxColumn.Width = 180;
			// 
			// createdDateDataGridViewTextBoxColumn
			// 
			this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
			this.createdDateDataGridViewTextBoxColumn.HeaderText = "작성일";
			this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
			this.createdDateDataGridViewTextBoxColumn.Width = 120;
			// 
			// createdByDataGridViewTextBoxColumn
			// 
			this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
			this.createdByDataGridViewTextBoxColumn.HeaderText = "작성자";
			this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
			this.createdByDataGridViewTextBoxColumn.Width = 120;
			// 
			// noteViewsNumberDataGridViewTextBoxColumn
			// 
			this.noteViewsNumberDataGridViewTextBoxColumn.DataPropertyName = "NoteViewsNumber";
			this.noteViewsNumberDataGridViewTextBoxColumn.HeaderText = "조회수";
			this.noteViewsNumberDataGridViewTextBoxColumn.Name = "noteViewsNumberDataGridViewTextBoxColumn";
			this.noteViewsNumberDataGridViewTextBoxColumn.Width = 90;
			// 
			// sfLectureNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 762);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "sfLectureNotes";
			this.Text = "sfLectureNotes";
			this.Load += new System.EventHandler(this.sfLectureNotes_Load);
			this.panel1.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panelMiddle2.ResumeLayout(false);
			this.panelMiddle2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLectureNotes)).EndInit();
			this.panelMiddle1.ResumeLayout(false);
			this.panelMiddle1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kLAS_DBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lectureNoteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.ComboBox cbxMenu;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblNameAndId;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Footer panelFooter;
		private System.Windows.Forms.Panel panelMiddle1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbxSelectCourse;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panelMiddle2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvLectureNotes;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbxSearchBased;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblCourseTime_Place;
		private System.Windows.Forms.Label lblCourseName_Id_lecturer;
		private KLAS_DBDataSet1 kLAS_DBDataSet1;
		private System.Windows.Forms.BindingSource lectureNoteBindingSource;
		private KLAS_DBDataSet1TableAdapters.LectureNoteTableAdapter lectureNoteTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noteViewsNumberDataGridViewTextBoxColumn;
	}
}