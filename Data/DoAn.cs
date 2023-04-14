using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDoAn.Data
{
	public class DoAn
	{
		public string Name { get; set; }
		public double Price { get; set; }	

		public DoAn()
		{
			this.Name = string.Empty;
			this.Price = 0;
		}
		public DoAn(string name, double price)
		{
			this.Name = name;
			this.Price = price;
		}
	}
}
