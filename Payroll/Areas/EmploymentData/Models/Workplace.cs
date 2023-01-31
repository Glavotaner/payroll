using System;
namespace Payroll.Areas.EmploymentData.Models
{
	public class Workplace
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public float Salary { get; set; }
		public bool Retired { get; set; }
	}
}

