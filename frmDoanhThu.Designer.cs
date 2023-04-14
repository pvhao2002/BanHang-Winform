namespace BanHangDoAn
{
	partial class frmDoanhThu
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
			this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.lvDetail = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDoanhThu
			// 
			this.dgvDoanhThu.AllowUserToResizeColumns = false;
			this.dgvDoanhThu.AllowUserToResizeRows = false;
			this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoanhThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDoanhThu.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvDoanhThu.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvDoanhThu.Location = new System.Drawing.Point(0, 0);
			this.dgvDoanhThu.MultiSelect = false;
			this.dgvDoanhThu.Name = "dgvDoanhThu";
			this.dgvDoanhThu.ReadOnly = true;
			this.dgvDoanhThu.RowHeadersWidth = 51;
			this.dgvDoanhThu.RowTemplate.Height = 24;
			this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoanhThu.Size = new System.Drawing.Size(1123, 359);
			this.dgvDoanhThu.TabIndex = 0;
			this.dgvDoanhThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 362);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(335, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chi tiết danh sách món ăn:";
			// 
			// lvDetail
			// 
			this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvDetail.FullRowSelect = true;
			this.lvDetail.GridLines = true;
			this.lvDetail.HideSelection = false;
			this.lvDetail.Location = new System.Drawing.Point(0, 397);
			this.lvDetail.MultiSelect = false;
			this.lvDetail.Name = "lvDetail";
			this.lvDetail.Size = new System.Drawing.Size(764, 334);
			this.lvDetail.TabIndex = 3;
			this.lvDetail.UseCompatibleStateImageBehavior = false;
			this.lvDetail.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Đơn giá";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Số lượng";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
			this.columnHeader4.Width = 100;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(805, 605);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tổng doanh thu:";
			// 
			// txtTongDoanhThu
			// 
			this.txtTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongDoanhThu.Location = new System.Drawing.Point(791, 650);
			this.txtTongDoanhThu.Name = "txtTongDoanhThu";
			this.txtTongDoanhThu.ReadOnly = true;
			this.txtTongDoanhThu.Size = new System.Drawing.Size(307, 38);
			this.txtTongDoanhThu.TabIndex = 5;
			// 
			// frmDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 732);
			this.Controls.Add(this.txtTongDoanhThu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lvDetail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDoanhThu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDoanhThu";
			this.Text = "frmDoanhThu";
			this.Load += new System.EventHandler(this.frmDoanhThu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDoanhThu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvDetail;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTongDoanhThu;
	}
}