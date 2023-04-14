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
	public partial class frmDoanhThu : Form
	{
		public frmDoanhThu()
		{
			InitializeComponent();
		}
		double tongDoanhThu()
		{
			double t = 0;
			foreach (var item in frmMain.listHoaDon)
			{
				t += item.TongTien;
			}
			return t;
		}
		private void frmDoanhThu_Load(object sender, EventArgs e)
		{
			dgvDoanhThu.DataSource = frmMain.listHoaDon.ToList();
			txtTongDoanhThu.Text = tongDoanhThu().ToString("#,###", frmOrder.cultureInfo) + " VND";
		}

		private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lvDetail.Items.Clear();
			int r = dgvDoanhThu.CurrentCell.RowIndex;
			var ID = dgvDoanhThu.Rows[r].Cells[0].Value.ToString();
			foreach (var item in frmMain.listHoaDon)
			{
				if (item.ID.ToString().Equals(ID))
				{
					foreach (var monAn in item.danhSachMonAn)
					{
						ListViewItem listViewItem = new ListViewItem(monAn.doAn.Name);
						listViewItem.SubItems.Add(monAn.doAn.Price.ToString("#,###", frmOrder.cultureInfo) + " VND");
						listViewItem.SubItems.Add(monAn.soLuong.ToString());
						listViewItem.SubItems.Add(monAn.thanhTien.ToString("#,###", frmOrder.cultureInfo) + " VND");
						lvDetail.Items.Add(listViewItem);	
					}
					break;
				}
			}
		}
	}
}
