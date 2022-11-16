using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models.ViewModels
{
	public class MovieCategoryIndexVM
	{
		public int Id { get; set; }
		public string MovieName { get; set; }
		public string TicketType { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class MovieCategoryVM
	{
		public int Id { get; set; }
		public string MovieName { get; set; }
		public string TicketType { get; set; }
		public int DisplayOrder { get; set; }
	}
}
