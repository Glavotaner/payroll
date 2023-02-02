using System;
using PayrollApp.Areas.ReimbursementsData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class ReimbursementAmount
	{
		public int Id { get; set; }

		public virtual Reimbursement Reimbursement { get; set; } = default!;
		public float Amount { get; set; }
	}
}

