using System;
namespace PayrollApp.Areas.HoursData.Models
{
	public class HourType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool Retired { get; set; }
	}
}

