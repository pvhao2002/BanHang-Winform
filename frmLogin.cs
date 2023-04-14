using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangDoAn
{
	public partial class frmLogin : Form
	{
		private static readonly string TAIKHOAN = "admin";
		private static readonly string MATKHAU = "123456";
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void resetText()
		{
			txtUsername.ResetText();
			txtPassword.ResetText();
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			if (TAIKHOAN.Equals(username) && MATKHAU.Equals(password))
			{
				frmMain frmMain = new frmMain();
				this.Hide();
				frmMain.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
			}
		}
	}
}
