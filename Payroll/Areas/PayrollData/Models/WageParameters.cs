using System;
namespace Payroll.Areas.PayrollData.Models
{
	public class WageParameters
	{
		public int Id { get; set; }
		public float MinBase { get; set; }
		public float MaxBase { get; set; }
		public float MinWage { get; set; }
		public DateTime ValidFrom { get; set; }
	}
}

