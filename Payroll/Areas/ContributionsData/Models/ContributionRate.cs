using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.CalculationData.Models
{
	public class ContributionRate
	{
		public ContributionRate()
		{
		}
		public int Id { get; set; }

		[ForeignKey("Contribution")]
		public int ContributionId { get; set; }
		public virtual Contribution Contribution { get; set; }

		public float Rate { get; set; }

		[Display(Name = "Valid From")]
		[DataType(DataType.Date)]
		public DateTime ValidFrom { get; set; }
	}
}

