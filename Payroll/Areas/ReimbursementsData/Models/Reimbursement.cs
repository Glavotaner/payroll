using System;
namespace Payroll.Areas.ReimbursementsData.Models
{
	public class Reimbursement
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool Retired { get; set; }
	}
}

