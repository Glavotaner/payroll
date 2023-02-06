using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
    public class Deductibles
    {
        public int Id { get; set; }

        [DataType(DataType.Currency), Range(0, Double.MaxValue)]
        public float Base { get; set; }

        [Display(Name = "Personal Deductible Coefficient")]
        [Range(0, 1)]
        public float PersonalCoefficient { get; set; }

        [Range(0, 1)]
        public float Dependent { get; set; }

        [Display(Name = "Partially Disabled Dependent")]
        [Range(0, 1)]
        public float DisabledDependentPartial { get; set; }

        [Display(Name = "Fully Disabled Dependent")]
        [Range(0, 1)]
        public float DisabledDependentFull { get; set; }

        [Display(Name = "First Child")]
        [Range(0, 1)]
        public float FirstChild { get; set; }

        [Display(Name = "Second Child")]
        [Range(0, 1)]
        public float SecondChild { get; set; }

        [Display(Name = "Third Child")]
        [Range(0, 1)]
        public float ThirdChild { get; set; }

        [Display(Name = "Fourth Child")]
        [Range(0, 1)]
        public float FourthChild { get; set; }

        [Display(Name = "Fifth Child")]
        [Range(0, 1)]
        public float FifthChild { get; set; }

        [Display(Name = "Sixth Child")]
        [Range(0, 1)]
        public float SixthChild { get; set; }

        [Display(Name = "Seventh Child")]
        [Range(0, 1)]
        public float SeventhChild { get; set; }

        [Display(Name = "Eighth Child")]
        [Range(0, 1)]
        public float EighthChild { get; set; }

        [Display(Name = "Ninth Child")]
        [Range(0, 1)]
        public float NinthChild { get; set; }

        [Display(Name = "Multiplication Coefficient")]
        [Range(0, 1)]
        public float MultiplicationCoefficient { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }
    }
}

