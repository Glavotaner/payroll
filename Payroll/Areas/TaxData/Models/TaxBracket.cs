using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.TaxData.Models
{
	public class TaxBracket
	{
		public int Id { get; set; }

		[Display(Name = "Lower Bound"), DataType(DataType.Currency), TaxBracketLowerBound]
		public float LowerBound { get; set; }

        [Display(Name = "Upper Bound"), DataType(DataType.Currency), TaxBracketUpperBound]
        public float? UpperBound { get; set; }

		[Range(0, 100)]
		public float Rate { get; set; }
	}
}

