using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.PersonData.Models
{
	public class Person
	{
		[MaxLength(13), PID]
		public string PID { get; set; } = default!;

		[Display(Name = "First Name")]
		public string FirstName { get; set; } = default!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = default!;

        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

		public Disability Disability { get; set; }
	}

	public enum Disability
	{
		Partial, Full, None
	}
}

