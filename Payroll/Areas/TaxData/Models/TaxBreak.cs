using System;
namespace PayrollApp.Areas.TaxData.Models
{
	public class TaxBreak
	{
		public int Id { get; set; }

		public string Name { get; set; } = default!;
		public float Rate { get; set; }
		public bool Retired { get; set; }
	}
}

