using System;
using PayrollApp.Areas.PersonData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class Labour
	{
		public int Id { get; set; }
		public int Year { get; set; }
		public int Month { get; set; }
		public virtual Employee Employee { get; set; }
		public int Hours { get; set; }
		public virtual ICollection<HourTypeAmount> HourTypeAmounts { get; set; }
	}
}

