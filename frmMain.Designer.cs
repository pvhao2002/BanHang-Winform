namespace BanHangDoAn
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnDoanhThu = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.pnContent = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(271, 832);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(271, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1123, 100);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1123, 100);
			this.label1.TabIndex = 1;
			this.label1.Text = "4P FFOOD";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(271, 255);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnOrder);
			this.groupBox1.Controls.Add(this.btnDoanhThu);
			this.groupBox1.Controls.Add(this.btnLogout);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Location = new System.Drawing.Point(0, 255);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(271, 577);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quản lý";
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
			this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(23, 499);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(216, 52);
			this.btnLogout.TabIndex = 0;
			this.btnLogout.Text = "Đăng xuất";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnDoanhThu
			// 
			this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
			this.btnDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
			this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
			this.btnDoanhThu.Location = new System.Drawing.Point(23, 407);
			this.btnDoanhThu.Name = "btnDoanhThu";
			this.btnDoanhThu.Size = new System.Drawing.Size(216, 52);
			this.btnDoanhThu.TabIndex = 0;
			this.btnDoanhThu.Text = "Doanh thu";
			this.btnDoanhThu.UseVisualStyleBackColor = false;
			this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
			this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.ForeColor = System.Drawing.Color.White;
			this.btnOrder.Location = new System.Drawing.Point(23, 299);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(216, 52);
			this.btnOrder.TabIndex = 0;
			this.btnOrder.Text = "Đặt món";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// pnContent
			// 
			this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnContent.Location = new System.Drawing.Point(271, 100);
			this.pnContent.Name = "pnContent";
			this.pnContent.Size = new System.Drawing.Size(1123, 732);
			this.pnContent.TabIndex = 3;
			this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1394, 832);
			this.Controls.Add(this.pnContent);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMain";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnDoanhThu;
		private System.Windows.Forms.Panel pnContent;
	}
}