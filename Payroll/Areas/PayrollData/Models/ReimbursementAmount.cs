using System;
using System.ComponentModel.DataAnnotations;
using PayrollApp.Areas.ReimbursementsData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class ReimbursementAmount
	{
		public int Id { get; set; }

		public virtual Reimbursement Reimbursement { get; set; } = default!;
		
		[DataType(DataType.Currency), Range(0, double.MaxValue)]
		public float Amount { get; set; }
	}
}

