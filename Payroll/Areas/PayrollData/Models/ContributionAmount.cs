using System;
using PayrollApp.Areas.CalculationData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class ContributionAmount
	{
		public int Id { get; set; }

		public virtual Contribution Contribution { get; set; } = default!;
		public float Amount { get; set; }
	}
}

