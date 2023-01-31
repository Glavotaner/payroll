using System;
using Payroll.Areas.ReimbursementsData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class ReimbursementAmount
	{
		public int Id { get; set; }

		public int ReimbursementId { get; set; }
		public virtual Reimbursement Reimbursement { get; set; }

        public int PayrollId { get; set; }
        public virtual Payroll Payroll { get; set; }

		public float Amount { get; set; }
	}
}

