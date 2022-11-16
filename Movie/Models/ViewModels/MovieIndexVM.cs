using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models.ViewModels
{
	internal class MovieIndexVM
	{
		public int Id { get; set; }
		public string MovieName { get; set; }
		public string Time { get; set; }
		public int TicketPrice { get; set; }
		public int Quantity { get; set; }
		public int TotalPrice { get; set; }
	}

	/// <summary>
	/// 供CreateProductForm, EditProductForm使用
	/// </summary>
	public class MovieVM
	{
		public int Id { get; set; }
		public string MovieId { get; set; }
		public string Time { get; set; }
		public int TicketPrice { get; set; }
		public int Quantity { get; set; }
		public int TotalPrice { get; set; }
	}
}
