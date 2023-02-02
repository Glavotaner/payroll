using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Bank
	{
		public int Id { get; set; }

		public string PID { get; set; } = default!;
		public string Name { get; set; } = default!;
		public string IBAN { get; set; } = default!;
		public virtual Address Address { get; set; } = default!;
	}
}

