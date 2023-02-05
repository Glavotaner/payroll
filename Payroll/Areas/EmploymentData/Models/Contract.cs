﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.PersonData.Models;

namespace PayrollApp.Areas.EmploymentData.Models
{
	public class Contract
	{
		public int Id { get; set; }

		[Range(0, 1)]
		public float Coefficient { get; set; }

		[DataType(DataType.Date), StartDate]
		public DateTime Start { get; set; }

        [DataType(DataType.Date), EndDate]
        public DateTime End { get; set; }

		[Display(Name = "Contract Type")]
		public virtual ContractType ContractType { get; set; } = default!;

		[Display(Name = "Workplace")]
		public virtual Workplace Workplace { get; set; } = default!;
    }
}

