using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Areas.ReimbursementsData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
    public class HourTypeAmount
    {
        public int Id { get; set; }

        [Display(Name = "Hour Type")]
        public virtual HourType HourType { get; set; } = default!;

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
    }
}

