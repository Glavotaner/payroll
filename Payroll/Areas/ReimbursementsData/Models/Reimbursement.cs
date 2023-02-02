using System;
namespace PayrollApp.Areas.ReimbursementsData.Models
{
	public class Reimbursement
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public bool Retired { get; set; }
	}
}

