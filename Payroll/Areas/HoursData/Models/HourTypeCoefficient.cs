using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.HoursData.Models
{
	public class HourTypeCoefficient
	{
		public int Id { get; set; }

		public int HourTypeId { get; set; }
		[ForeignKey("HourType")]
		public virtual HourType HourType { get; set; }

		public float Coefficient { get; set; }
		public DateTime ValidFrom { get; set; }
	}
}

