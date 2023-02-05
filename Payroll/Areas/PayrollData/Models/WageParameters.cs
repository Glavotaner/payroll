using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class WageParameters
	{
		public int Id { get; set; }

		[Display(Name = "Min Base"), DataType(DataType.Currency), Range(0, double.MaxValue)]
		public float MinBase { get; set; }

        [Display(Name = "Max Base"), DataType(DataType.Currency), Range(0, double.MaxValue)]
        public float MaxBase { get; set; }

        [Display(Name = "Min Wage"), DataType(DataType.Currency),  Range(0, double.MaxValue)]
        public float MinWage { get; set; }

        [Display(Name = "Valid From"), DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }
	}
}

