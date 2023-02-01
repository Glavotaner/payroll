using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.CalculationData.Models
{
	public class Contribution
	{
		public int Id { get; set; }

		public string Name { get; set; }

		[Display(Name = "From Pay")]
		public bool FromPay { get; set; }

		public bool Retired { get; set; }
	}
}

