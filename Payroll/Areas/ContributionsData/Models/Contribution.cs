﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Areas.CalculationData.Models
{
	public class Contribution
	{
		public Contribution()
		{
		}
		public int Id { get; set; }

		public string Name { get; set; }

		[Display(Name = "From Pay")]
		public bool FromPay { get; set; }

		public bool Retired { get; set; }
	}
}

