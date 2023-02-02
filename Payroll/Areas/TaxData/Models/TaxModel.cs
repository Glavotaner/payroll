using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.TaxData.Models
{
	public class TaxModel
	{
		public int Id { get; set; }

        [Display(Name = "Tax Brackets")]
        public virtual ICollection<TaxBracket> TaxBrackets { get; set; } = default!;

		[Display(Name = "Valid From")]
		[DataType(DataType.Date)]
		public DateTime ValidFrom { get; set; }
	}
}

