using System;
using Payroll.Areas.ReimbursementsData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class ReimbursementAmount
	{
		public int Id { get; set; }

		public virtual Reimbursement Reimbursement { get; set; }
		public float Amount { get; set; }
	}
}

