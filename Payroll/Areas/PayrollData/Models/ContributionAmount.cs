using System;
using Payroll.Areas.CalculationData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class ContributionAmount
	{
		public int Id { get; set; }

		public int ContributionId { get; set; }
		public virtual Contribution Contribution { get; set; }

        public int PayrollId { get; set; }
        public virtual Payroll Payroll { get; set; }

		public float Amount { get; set; }
	}
}

