using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
    public class Deductibles
    {
        public int Id { get; set; }

        [DataType(DataType.Currency), Range(0, Double.MaxValue)]
        public decimal Base { get; set; }

        [Display(Name = "Personal Deductible Coefficient")]
        [Range(0, 1)]
        public float PersonalCoefficient { get; set; }

        [Range(0, 1)]
        public decimal Dependent { get; set; }

        [Display(Name = "Partially Disabled Dependent")]
        [Range(0, 1)]
        public decimal DisabledDependentPartial { get; set; }

        [Display(Name = "Fully Disabled Dependent")]
        [Range(0, 1)]
        public decimal DisabledDependentFull { get; set; }

        [Display(Name = "First Child")]
        [Range(0, 1)]
        public decimal FirstChild { get; set; }

        [Display(Name = "Second Child")]
        [Range(0, 1)]
        public decimal SecondChild { get; set; }

        [Display(Name = "Third Child")]
        [Range(0, 1)]
        public decimal ThirdChild { get; set; }

        [Display(Name = "Fourth Child")]
        [Range(0, 1)]
        public decimal FourthChild { get; set; }

        [Display(Name = "Fifth Child")]
        [Range(0, 1)]
        public decimal FifthChild { get; set; }

        [Display(Name = "Sixth Child")]
        [Range(0, 1)]
        public decimal SixthChild { get; set; }

        [Display(Name = "Seventh Child")]
        [Range(0, 1)]
        public decimal SeventhChild { get; set; }

        [Display(Name = "Eighth Child")]
        [Range(0, 1)]
        public decimal EighthChild { get; set; }

        [Display(Name = "Ninth Child")]
        [Range(0, 1)]
        public decimal NinthChild { get; set; }

        [Display(Name = "Multiplication Coefficient")]
        [Range(0, 1)]
        public float MultiplicationCoefficient { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }
    }
}

