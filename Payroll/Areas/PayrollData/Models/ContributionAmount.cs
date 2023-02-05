using System;
using System.ComponentModel.DataAnnotations;
using PayrollApp.Areas.CalculationData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class ContributionAmount
	{
		public int Id { get; set; }

		public virtual Contribution Contribution { get; set; } = default!;

		[DataType(DataType.Currency), Range(0, double.MaxValue)]
		public float Amount { get; set; }
	}
}

