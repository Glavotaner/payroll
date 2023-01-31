﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Areas.PersonData.Models
{
	public class Dependent
	{
		public int Id { get; set; }

		[Display(Name = "Child in Line")]
		public int? ChildInLine { get; set; }
	}
}

