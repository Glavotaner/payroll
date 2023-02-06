using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.ReimbursementsData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
    public class ReimbursementAmount
    {
        public int Id { get; set; }

        public virtual Reimbursement Reimbursement { get; set; } = default!;

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float Amount { get; set; }
    }
}

