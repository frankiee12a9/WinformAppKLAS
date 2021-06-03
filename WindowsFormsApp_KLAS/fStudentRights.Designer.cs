
namespace WindowsFormsApp_KLAS
{
	partial class fStudentRights
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.cbxMenu = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblNameAndId = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelMiddle = new System.Windows.Forms.Panel();
			this.panelFooter = new WindowsFormsApp_KLAS.Footer();
			this.panelHeader.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.IndianRed;
			this.panelHeader.Controls.Add(this.cbxMenu);
			this.panelHeader.Controls.Add(this.panel3);
			this.panelHeader.Controls.Add(this.panel1);
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(999, 78);
			this.panelHeader.TabIndex = 0;
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
			this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged_1);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnLogout);
			this.panel3.Controls.Add(this.lblNameAndId);
			this.panel3.Location = new System.Drawing.Point(711, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(279, 78);
			this.panel3.TabIndex = 3;
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
			this.lblNameAndId.Location = new System.Drawing.Point(14, 34);
			this.lblNameAndId.Name = "lblNameAndId";
			this.lblNameAndId.Size = new System.Drawing.Size(50, 12);
			this.lblNameAndId.TabIndex = 0;
			this.lblNameAndId.Text = "이름(ID)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(96, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(213, 78);
			this.panel1.TabIndex = 2;
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
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panelFooter);
			this.panel2.Location = new System.Drawing.Point(0, 704);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(999, 82);
			this.panel2.TabIndex = 0;
			// 
			// panelMiddle
			// 
			this.panelMiddle.BackColor = System.Drawing.Color.White;
			this.panelMiddle.Location = new System.Drawing.Point(0, 84);
			this.panelMiddle.Name = "panelMiddle";
			this.panelMiddle.Size = new System.Drawing.Size(996, 614);
			this.panelMiddle.TabIndex = 1;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.IndianRed;
			this.panelFooter.Location = new System.Drawing.Point(-3, 3);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(1002, 82);
			this.panelFooter.TabIndex = 0;
			// 
			// fStudentRights
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 788);
			this.Controls.Add(this.panelMiddle);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelHeader);
			this.Name = "fStudentRights";
			this.Text = "fStudentRights";
			this.Load += new System.EventHandler(this.fStudentRights_Load);
			this.panelHeader.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Panel panel2;
		private Footer panelFooter;
		private System.Windows.Forms.Panel panelMiddle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxMenu;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblNameAndId;
	}
}