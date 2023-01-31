using System;
using System.ComponentModel.DataAnnotations;
using Payroll.Areas.HoursData.Models;
using Payroll.Areas.ReimbursementsData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class HourTypeAmount
	{
		public int Id { get; set; }

		public int HourTypeId { get; set; }

		[Display(Name = "Hour Type")]
		public virtual HourType HourType { get; set; }

        public int LabourId { get; set; }
        public virtual Labour Labour { get; set; }

		public float Amount { get; set; }
	}
}

