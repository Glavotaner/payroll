using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Address
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Number { get; set; } = default!;
		[ForeignKey("City")]
		public int CityId { get; set; }
		public virtual City City { get; set; } = default!;
	}
}

