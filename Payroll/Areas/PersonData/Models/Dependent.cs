using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Areas.PersonData.Models
{
	public class Dependent
	{
		public int Id { get; set; }

		[Display(Name = "Child in Line"), Range(0, int.MaxValue)]
		public int? ChildInLine { get; set; }
	}
}

