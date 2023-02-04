using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.TaxData.Models
{
	public class TaxBracket
	{
		public int Id { get; set; }

		[Display(Name = "Lower Bound")]
		public float LowerBound { get; set; }

        [Display(Name = "Upper Bound")]
        public float? UpperBound { get; set; }
		public float Rate { get; set; }
	}
}

