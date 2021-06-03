
namespace WindowsFormsApp_KLAS
{
	partial class fLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ckbIdSave = new System.Windows.Forms.CheckBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtId);
			this.panel1.Location = new System.Drawing.Point(296, 147);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 79);
			this.panel1.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(65, 48);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(206, 21);
			this.txtPassword.TabIndex = 0;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(65, 21);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(206, 21);
			this.txtId.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lblHeader);
			this.panel2.Location = new System.Drawing.Point(351, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(216, 73);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(51, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "U N I V E R S I T Y\r\n";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblHeader.Location = new System.Drawing.Point(35, 12);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(144, 21);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "KWANGWOON\r\n";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ckbIdSave);
			this.panel3.Controls.Add(this.button6);
			this.panel3.Controls.Add(this.button5);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.btnLogin);
			this.panel3.Location = new System.Drawing.Point(296, 243);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(339, 201);
			this.panel3.TabIndex = 1;
			// 
			// ckbIdSave
			// 
			this.ckbIdSave.AutoSize = true;
			this.ckbIdSave.Location = new System.Drawing.Point(65, 47);
			this.ckbIdSave.Name = "ckbIdSave";
			this.ckbIdSave.Size = new System.Drawing.Size(88, 16);
			this.ckbIdSave.TabIndex = 2;
			this.ckbIdSave.Text = "아이디 저장";
			this.ckbIdSave.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(66, 74);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(102, 30);
			this.button6.TabIndex = 1;
			this.button6.Text = "개인번호 조회";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(174, 74);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(97, 30);
			this.button5.TabIndex = 1;
			this.button5.Text = "비밀번호 등록";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(174, 38);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 30);
			this.button4.TabIndex = 1;
			this.button4.Text = "비밀번호 찾기";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(66, 146);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(205, 30);
			this.button3.TabIndex = 1;
			this.button3.Text = "개인정보처리방짐";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(66, 110);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(205, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "비밀번호 오류 5회 이상 제한 \r\n";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(65, 3);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(206, 30);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "로그인";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 593);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "fLogin";
			this.Text = "Login Form";
			this.Load += new System.EventHandler(this.fLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox ckbIdSave;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnLogin;
	}
}

