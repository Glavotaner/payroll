using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.ThirdParties.Models
{
	public class Address
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Number { get; set; }
		[ForeignKey("City")]
		public int CityId { get; set; }
		public virtual City City { get; set; }
	}
}

