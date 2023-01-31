using System;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Areas.PersonData.Models
{
	public class Person
	{
		public string PID { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
		[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

		public Disability Disability { get; set; }
	}

	public enum Disability
	{
		Partial, Full, None
	}
}

