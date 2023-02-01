using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.CalculationData.Models
{
	public class ContributionsModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		[Display(Name = "Contribution Rates")]
		public virtual ICollection<ContributionRate> ContributionRates { get; set; }
		public bool Retired { get; set; }
	}
}

