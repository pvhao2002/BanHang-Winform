namespace BanHangDoAn
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 463);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.txtPassword);
			this.panel2.Controls.Add(this.txtUsername);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(550, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(524, 463);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(550, 463);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.Location = new System.Drawing.Point(465, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 45);
			this.btnExit.TabIndex = 3;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lavender;
			this.label1.Location = new System.Drawing.Point(98, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 65);
			this.label1.TabIndex = 1;
			this.label1.Text = "ĐĂNG NHẬP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(38, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tài khoản:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(38, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật khẩu:";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(200, 196);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(277, 38);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(200, 266);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(277, 38);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.BackColor = System.Drawing.Color.Orange;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(200, 360);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(162, 57);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 463);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
	}
}

