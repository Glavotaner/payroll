using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.CalculationData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
    public class ContributionAmount
    {
        public int Id { get; set; }

        public virtual Contribution Contribution { get; set; } = default!;

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
    }
}

