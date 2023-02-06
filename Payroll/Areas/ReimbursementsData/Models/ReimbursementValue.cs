using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
    public class ReimbursementValue
    {
        public int Id { get; set; }

        public virtual Reimbursement Reimbursement { get; set; } = default!;

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }

        [Display(Name = "Valid From")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime ValidFrom { get; set; }
    }
}

