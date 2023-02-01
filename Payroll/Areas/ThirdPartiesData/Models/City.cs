using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class City
	{
		public int Id { get; set; }

		public string IBAN { get; set; }
		public string JOPPD { get; set; }
		public string Name { get; set; }

		[Display(Name = "Postal Code")]
		public string PostalCode { get; set; }

		[Display(Name = "Tax Rate")]
		public float TaxRate { get; set; }
	}
}

