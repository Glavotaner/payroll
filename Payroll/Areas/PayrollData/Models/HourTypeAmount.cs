using System;
using System.ComponentModel.DataAnnotations;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Areas.ReimbursementsData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class HourTypeAmount
	{
		public int Id { get; set; }

		[Display(Name = "Hour Type")]
		public virtual HourType HourType { get; set; } = default!;

		[DataType(DataType.Currency), Range(0, double.MaxValue)]
		public float Amount { get; set; }
	}
}

