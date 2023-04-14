using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDoAn.Data
{
	public class HoaDon
	{
		public int ID { get; set; }
		public List<ChiTietHoaDon> danhSachMonAn { get; set; }
		public int TongSoMon { get; set; }
		public DateTime ngayMua { get; set; }
		public double TongTien { get; set; }
		public HoaDon()
		{
			ID = 0;
			TongSoMon = 0;
			danhSachMonAn = new List<ChiTietHoaDon>();
			TongTien = 0;
		}
		public HoaDon(List<ChiTietHoaDon> danhSachMonAn, double tongTien, DateTime ngayMua)
		{
			ID = 0;
			TongSoMon = 0;
			this.danhSachMonAn = danhSachMonAn;
			TongTien = tongTien;
			this.ngayMua = ngayMua;
		}
	}
}
