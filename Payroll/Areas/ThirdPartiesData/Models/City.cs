using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class City
	{
		public int Id { get; set; }

		public string IBAN { get; set; } = default!;
		public string JOPPD { get; set; } = default!;
		public string Name { get; set; } = default!;

		[Display(Name = "Postal Code")]
		public string? PostalCode { get; set; }

		[Display(Name = "Tax Rate")]
		public float TaxRate { get; set; }
	}
}

