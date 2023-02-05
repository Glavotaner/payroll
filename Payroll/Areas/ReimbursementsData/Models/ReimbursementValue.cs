using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
	public class ReimbursementValue
	{
		public int Id { get; set; }

		public virtual Reimbursement Reimbursement { get; set; } = default!;
		
		[DataType(DataType.Currency), Range(0, double.MaxValue)]
		public float Value { get; set; }

		[Display(Name = "Valid From"), DataType(DataType.Date)]
		public DateTime ValidFrom { get; set; }
	}
}

