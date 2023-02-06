using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
    public class Deductibles
    {
        public int Id { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, Double.MaxValue)]
        public decimal Base { get; set; }

        [Display(Name = "Personal Deductible Coefficient")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public float PersonalCoefficient { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal Dependent { get; set; }

        [Display(Name = "Partially Disabled Dependent")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal DisabledDependentPartial { get; set; }

        [Display(Name = "Fully Disabled Dependent")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal DisabledDependentFull { get; set; }

        [Display(Name = "First Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal FirstChild { get; set; }

        [Display(Name = "Second Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal SecondChild { get; set; }

        [Display(Name = "Third Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal ThirdChild { get; set; }

        [Display(Name = "Fourth Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal FourthChild { get; set; }

        [Display(Name = "Fifth Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal FifthChild { get; set; }

        [Display(Name = "Sixth Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal SixthChild { get; set; }

        [Display(Name = "Seventh Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal SeventhChild { get; set; }

        [Display(Name = "Eighth Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal EighthChild { get; set; }

        [Display(Name = "Ninth Child")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        [Range(0, 1)]
        public decimal NinthChild { get; set; }

        [Display(Name = "Multiplication Coefficient")]
        [Range(0, 1)]
        public float MultiplicationCoefficient { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime ValidFrom { get; set; }
    }
}

