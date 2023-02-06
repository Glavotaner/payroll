using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.PayrollData.Models
{
    public class WageParameters
    {
        public int Id { get; set; }

        [Display(Name = "Min Base")]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal MinBase { get; set; }

        [Display(Name = "Max Base")]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal MaxBase { get; set; }

        [Display(Name = "Min Wage")]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal MinWage { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime ValidFrom { get; set; }
    }
}

