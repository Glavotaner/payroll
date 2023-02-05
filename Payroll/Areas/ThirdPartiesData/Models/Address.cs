using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Street
	{
		public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = default!;

		public virtual City City { get; set; } = default!;
	}
}

