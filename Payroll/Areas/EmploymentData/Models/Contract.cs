using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.PersonData.Models;

namespace PayrollApp.Areas.EmploymentData.Models
{
	public class Contract
	{
		public int Id { get; set; }

		public float Coefficient { get; set; }

		[DataType(DataType.Date)]
		public DateTime Start { get; set; }

        [DataType(DataType.Date)]
        public DateTime End { get; set; }

		[Display(Name = "Contract Type")]
		public virtual ContractType ContractType { get; set; }

        [Display(Name = "Workplace")]
        public virtual Workplace Workplace { get; set; }
    }
}

