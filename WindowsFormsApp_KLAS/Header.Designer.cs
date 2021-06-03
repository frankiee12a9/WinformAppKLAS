
namespace WindowsFormsApp_KLAS
{
	partial class Header
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
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
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(76, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(213, 78);
			this.panel1.TabIndex = 1;
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
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnLogout);
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Location = new System.Drawing.Point(650, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 78);
			this.panel2.TabIndex = 1;
			// 
			// btnLogout
			// 
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogout.Location = new System.Drawing.Point(168, 29);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(99, 23);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Logout \r\n";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(52, 34);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(50, 12);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "이름(ID)";
			// 
			// Header
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Header";
			this.Size = new System.Drawing.Size(999, 78);
			this.Load += new System.EventHandler(this.Header_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblName;
	}
}
