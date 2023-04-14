using BanHangDoAn.Data;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangDoAn
{
	public partial class frmOrder : Form
	{
		HoaDon hoaDon { get; set; }
		public static CultureInfo cultureInfo = new CultureInfo("vi-VN");
		public frmOrder()
		{
			InitializeComponent();
			hoaDon = new HoaDon();
			hoaDon.ID = frmMain.listHoaDon.Count + 1;
		}

		private void frmOrder_Load(object sender, EventArgs e)
		{

		}

		private void picDuiga_Click(object sender, EventArgs e)
		{
			var item = sender as PictureBox;
			if (item != null)
			{
				txtGia.Text = item.Tag.ToString();
				Panel parent = item.Parent as Panel;
				if (parent != null)
				{
                    System.Windows.Forms.Label label = parent.Controls[1] as System.Windows.Forms.Label;
					if (label != null)
					{
						txtTenMon.Text = label.Text;
					}

				}

			}

		}
		double thanhTien()
		{
			double t = 0;
			foreach (var item in hoaDon.danhSachMonAn)
			{
				t += item.thanhTien;
			}
			return t;
		}

		private void btnThemMon_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTenMon.Text) || string.IsNullOrEmpty(txtGia.Text))
			{
				return;
			}
			foreach (var item in hoaDon.danhSachMonAn)
			{
				if (item.doAn.Name.Equals(txtTenMon.Text))
				{
					foreach (ListViewItem itemRow in lvHoaDon.Items)
					{
						if (itemRow.SubItems[0].Text.Equals(txtTenMon.Text))
						{
							item.soLuong++;
							item.thanhTien = item.doAn.Price * item.soLuong;
							hoaDon.TongTien = thanhTien();
							txtTongTien.Text = hoaDon.TongTien.ToString("#,###", cultureInfo) + " VND";
							itemRow.SubItems[1].Text = item.soLuong.ToString();
							return;
						}
					}
				}
			}
			ChiTietHoaDon cthd = new ChiTietHoaDon();
			cthd.doAn.Name = txtTenMon.Text;
			cthd.doAn.Price = double.Parse(txtGia.Text);
			cthd.soLuong = int.Parse(nmrSoLuong.Value.ToString());
			cthd.thanhTien = cthd.soLuong * cthd.doAn.Price;
			hoaDon.danhSachMonAn.Add(cthd);
			ListViewItem itemLV = new ListViewItem(cthd.doAn.Name);
			itemLV.SubItems.Add(cthd.soLuong.ToString());
			itemLV.SubItems.Add(cthd.doAn.Price.ToString());
			itemLV.SubItems.Add(cthd.thanhTien.ToString("#,###", cultureInfo) + " VND");
			lvHoaDon.Items.Add(itemLV);
			hoaDon.TongTien = thanhTien();
			txtTongTien.Text = hoaDon.TongTien.ToString("#,###", cultureInfo) + " VND";
		}
		void exportFile(string sheetName, string title)
		{
			// Tao cac doi tuong exel
			Microsoft.Office.Interop.Excel.Application oExel = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel.Workbooks oBooks;
			Microsoft.Office.Interop.Excel.Sheets oSheets;
			Microsoft.Office.Interop.Excel.Workbook oBook;
			Microsoft.Office.Interop.Excel.Worksheet oSheet;

			// Tao moi mot Excel WorkBook
			oExel.Visible = true;
			oExel.DisplayAlerts = false;
			oExel.Application.SheetsInNewWorkbook = 1;
			oBooks = oExel.Workbooks;
			oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExel.Workbooks.Add(Type.Missing));
			oSheets = oBook.Worksheets;
			oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
			oSheet.Name = sheetName;

			// Tao phan tieu de
			Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A12", "D12");

			head.MergeCells = true;
			head.Value2 = title;
			head.Font.Name = "Times New Roman";
			head.Font.Size = "20";
			head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


			// Tao tieu de ngay
			Microsoft.Office.Interop.Excel.Range ngayMua = oSheet.get_Range("A3", "A3");
			ngayMua.Value2 = "Ngày: ";
			ngayMua.ColumnWidth = 5;

			Microsoft.Office.Interop.Excel.Range ngayMua1 = oSheet.get_Range("B3", "B3");
			ngayMua.Value2 = hoaDon.ngayMua.ToString();
			ngayMua.ColumnWidth = 25;

			// Tao tieu de các cọt
			Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A5", "A5");
			ngayMua.Value2 = "Tên món";
			ngayMua.ColumnWidth = 25;

			Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B5", "B5");
			ngayMua.Value2 = "Số lượng";
			ngayMua.ColumnWidth = 15;

			Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C5", "C5");
			ngayMua.Value2 = "Đơn giá";
			ngayMua.ColumnWidth = 15;

			Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D5", "D5");
			ngayMua.Value2 = "Thành tiền";
			ngayMua.ColumnWidth = 20;


			Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A5", "D5");
			rowHead.Font.Bold = true;

			// Ke vien
			rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

			// Thiet lap mau nen
			rowHead.Interior.ColorIndex = 6;
			rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

			// Tao mang theo du lieu
			object[,] arr = new object[hoaDon.danhSachMonAn.Count, 4];
			for (int row = 0; row < hoaDon.danhSachMonAn.Count; row++)
			{
				ChiTietHoaDon ct = hoaDon.danhSachMonAn[row];
				arr[row, 0] = ct.doAn.Name;
				arr[row, 1] = ct.soLuong;
				arr[row, 2] = ct.doAn.Price;
				arr[row, 3] = ct.thanhTien;
			}

			// thiet lap vung dien du lieu
			int rowStart = 6;
			int columnStart = 1;
			int rowEnd = rowStart + hoaDon.danhSachMonAn.Count - 2;
			int columnEnd = 4;

			// O bat dau dien du lieu
			Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

			// o ket thuc dien du lieu
			Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

			// lay ve vung dien du lieu
			Microsoft.Office.Interop.Excel.Range rang = oSheet.get_Range(c1, c2);

			// dien du lieu
			rang.Value = arr;

			// ke vien
			rang.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

			// can giua ca bang
			oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


		}

		private void button1_Click(object sender, EventArgs e)
		{
			hoaDon.ngayMua = DateTime.Now;
			hoaDon.TongSoMon = hoaDon.danhSachMonAn.Count;
			frmMain.listHoaDon.Add(hoaDon);
			exportFile("Bill", "Hóa đơn thanh toán");

			txtTenMon.ResetText();
			txtGia.ResetText();
			txtTongTien.ResetText();
			lvHoaDon.Items.Clear();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bmp, 0, 0);
		}
		Bitmap bmp;
	}
}
