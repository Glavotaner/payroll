using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Bank
	{
		public int Id { get; set; }

		[PID]
		public string PID { get; set; } = default!;

		[MaxLength(100)]
		public string Name { get; set; } = default!;

        [IBAN]
        public string IBAN { get; set; } = default!;

		public virtual Street Street { get; set; } = default!;
        
		[MaxLength(10)]
		public string StreetNumber { get; set; } = default!;
	}
}

