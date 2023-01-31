using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.ReimbursementsData.Models
{
	public class ReimbursementValue
	{
		public int Id { get; set; }

		public int ReimbursementId { get; set; }
		[ForeignKey("Reimbursement")]
		public virtual Reimbursement Reimbursement { get; set; }

		public float Value { get; set; }
		public DateTime ValidFrom { get; set; }
	}
}

