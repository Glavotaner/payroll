using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.HoursData.Models
{
	public class HoursFund
	{
		public int Id { get; set; }

		[Range(2022, 9999)]
		public int Year { get; set; }

		[Range(1, 12)]
		public int Month { get; set; }

		[Range(0, 500)]
		public int Hours { get; set; }
	}
}

