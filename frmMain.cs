using BanHangDoAn.Data;
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
	public partial class frmMain : Form
	{
		public static List<HoaDon> listHoaDon { get; set; }
		public frmMain()
		{
			InitializeComponent();
			listHoaDon = new List<HoaDon>();
			frmOrder frmOrder = new frmOrder();
			frmOrder.TopLevel = false;
			pnContent.Controls.Add(frmOrder);
			frmOrder.Dock = DockStyle.Fill;
			frmOrder.Show();
		}

		private void btnLogout_MouseMove(object sender, MouseEventArgs e)
		{
			btnLogout.FlatAppearance.BorderColor = Color.White;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogout_MouseLeave(object sender, EventArgs e)
		{
			btnLogout.FlatAppearance.BorderColor = groupBox1.BackColor;
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			pnContent.Controls.Clear();
			frmOrder frmOrder = new frmOrder();
			frmOrder.TopLevel = false;
			pnContent.Controls.Add(frmOrder);
			frmOrder.Dock = DockStyle.Fill;
			frmOrder.Show();
		}

		private void pnContent_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnDoanhThu_Click(object sender, EventArgs e)
		{
			pnContent.Controls.Clear();
			frmDoanhThu f = new frmDoanhThu();
			f.TopLevel = false;
			pnContent.Controls.Add(f);
			f.Dock = DockStyle.Fill;
			f.Show();
		}
	}
}
