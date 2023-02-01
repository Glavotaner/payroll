using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Payroll.Areas.PersonData.Models;

namespace Payroll.Areas.EmploymentData.Models
{
	public class Contract
	{
		public int Id { get; set; }

		public virtual Employee Employee { get; set; }

		public float Coefficient { get; set; }

		[DataType(DataType.Date)]
		public DateTime Start { get; set; }

        [DataType(DataType.Date)]
        public DateTime End { get; set; }

		public int ContractTypeId { get; set; }
		[Display(Name = "Contract Type")]
		public virtual ContractType ContractType { get; set; }

        public int WorkplaceId { get; set; }
        [Display(Name = "Workplace")]
        public virtual Workplace Workplace { get; set; }
    }
}

