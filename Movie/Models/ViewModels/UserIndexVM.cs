using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		// public string Password { get; set; }

		public string Name { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
	}
}
