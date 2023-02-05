using System;
using System.ComponentModel.DataAnnotations;
using PayrollApp.Areas.PersonData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class Labour
	{
		public int Id { get; set; }

		[Range(2022, 9999)]
		public int Year { get; set; }

		[Range(1, 12)]
		public int Month { get; set; }
		public virtual Employee Employee { get; set; } = default!;

		[Range(0, int.MaxValue)]
		public int Hours { get; set; }

		[Display(Name = "Hour Type Amounts")]
		public virtual ICollection<HourTypeAmount> HourTypeAmounts { get; set; } = default!;
	}
}

