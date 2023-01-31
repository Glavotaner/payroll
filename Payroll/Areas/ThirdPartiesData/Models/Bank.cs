using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.ThirdParties.Models
{
	public class Bank
	{
		public Bank()
		{
		}
		public int Id { get; set; }

		public string PID { get; set; }
		public string Name { get; set; }
		public string IBAN { get; set; }

		[ForeignKey("Address")]
		public int AddressId { get; set; }
		public virtual Address Address { get; set; }
	}
}

