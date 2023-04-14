using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDoAn.Data
{
	public class ChiTietHoaDon
	{
		public DoAn doAn { get; set; }
		public int soLuong { get; set; }
		public double thanhTien { get; set; }
		public ChiTietHoaDon()
		{
			doAn = new DoAn();
			soLuong = 0;
			thanhTien = 0;
		}
		public ChiTietHoaDon(DoAn doAn, int soluong, double thanhtien)
		{
			this.doAn = doAn;
			this.soLuong = soluong;
			this.thanhTien = thanhtien;
		}
	}
}
