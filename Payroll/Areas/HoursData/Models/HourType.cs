using System;
namespace PayrollApp.Areas.HoursData.Models
{
	public class HourType
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public bool Retired { get; set; }
	}
}

