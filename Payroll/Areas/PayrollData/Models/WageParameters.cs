using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class WageParameters
	{
		public int Id { get; set; }

		[Display(Name = "Min Base")]
		public float MinBase { get; set; }

        [Display(Name = "Max Base")]
        public float MaxBase { get; set; }

        [Display(Name = "Min Wage")]
        public float MinWage { get; set; }

        [Display(Name = "Valid From")]
        public DateTime ValidFrom { get; set; }
	}
}

