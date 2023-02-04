using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class City
	{
		public int Id { get; set; }

        // TODO reuse
        [MaxLength(34), IBAN]
		public string IBAN { get; set; } = default!;

        [StringLength(5, MinimumLength = 5), JOPPD]
		public string JOPPD { get; set; } = default!;

		[MaxLength(100)]
		public string Name { get; set; } = default!;

		[Display(Name = "Postal Code"), StringLength(5, MinimumLength = 5)]
        public string? PostalCode { get; set; }

		[Display(Name = "Tax Rate")]
		[Range(0, 100)]
		public float TaxRate { get; set; }
	}
}

