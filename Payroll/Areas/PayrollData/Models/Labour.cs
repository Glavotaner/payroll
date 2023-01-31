using System;
using Payroll.Areas.PersonData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class Labour
	{
		public int Id { get; set; }
		public int Year { get; set; }
		public int Month { get; set; }
		public virtual Employee Employee { get; set; }
		public int Hours { get; set; }
	}
}

