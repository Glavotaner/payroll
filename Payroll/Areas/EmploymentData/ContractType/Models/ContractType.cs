﻿using System;
namespace Payroll.Areas.EmploymentData.ContractType.Models
{
	public class ContractType
	{
		public ContractType()
		{
		}
		public int Id { get; set; }

		public string Name { get; set; }
		public bool Retired { get; set; }
	}
}

