using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollApp.Areas.ThirdParties.Models
{
	public class Bank
	{
		public int Id { get; set; }

		public string PID { get; set; }
		public string Name { get; set; }
		public string IBAN { get; set; }
		public virtual Address Address { get; set; }
	}
}

