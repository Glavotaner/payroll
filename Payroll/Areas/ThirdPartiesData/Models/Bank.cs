using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Bank
	{
		public int Id { get; set; }

		[StringLength(13, MinimumLength = 13)]
		[PID]
		public string PID { get; set; } = default!;

		[MaxLength(100)]
		public string Name { get; set; } = default!;

		// TODO reuse
        [MaxLength(34)]
		[IBAN]
        public string IBAN { get; set; } = default!;

        public virtual Address Address { get; set; } = default!;
	}
}

