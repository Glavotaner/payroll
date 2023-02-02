using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.HoursData.Models
{
	public class HourTypeCoefficient
	{
		public int Id { get; set; }

		public virtual HourType HourType { get; set; } = default!;

		public float Coefficient { get; set; }
		public DateTime ValidFrom { get; set; }
	}
}

