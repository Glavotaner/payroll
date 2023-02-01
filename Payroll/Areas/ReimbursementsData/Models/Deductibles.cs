using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
	public class Deductibles
	{
		public int Id { get; set; }

		public float Base { get; set; }
		public float Personal { get; set; }
		public float Dependent { get; set; }

		[Display(Name = "Partially Disabled Dependent")]
		public float DisabledDependentPartial { get; set; }

        [Display(Name = "Fully Disabled Dependent")]
        public float DisabledDependentFull { get; set; }

        [Display(Name = "First Child")]
        public float FirstChild { get; set; }

        [Display(Name = "Second Child")]
        public float SecondChild { get; set; }

        [Display(Name = "Third Child")]
        public float ThirdChild { get; set; }

        [Display(Name = "Fourth Child")]
        public float FourthChild { get; set; }

        [Display(Name = "Fifth Child")]
        public float FifthChild { get; set; }

        [Display(Name = "Sixth Child")]
        public float SixthChild { get; set; }

        [Display(Name = "Seventh Child")]
        public float SeventhChild { get; set; }

        [Display(Name = "Eighth Child")]
        public float EighthChild { get; set; }

        [Display(Name = "Ninth Child")]
        public float NinthChild { get; set; }

        [Display(Name = "Multiplication Coefficient")]
        public float MultiplicationCoefficient { get; set; }

        [Display(Name = "Valid From")]
        public DateTime ValidFrom { get; set; }
	}
}

