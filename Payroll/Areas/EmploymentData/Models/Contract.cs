using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Areas.EmploymentData.Models
{
	public class Contract
	{
		public Contract()
		{
		}
		public int Id { get; set; }

		public float Coefficient { get; set; }

		[DataType(DataType.Date)]
		public DateTime Start { get; set; }

        [DataType(DataType.Date)]
        public DateTime End { get; set; }

		[ForeignKey("ContractType")]
		public int ContractTypeId { get; set; }
		[Display(Name = "Contract Type")]
		public virtual ContractType ContractType { get; set; }

        [ForeignKey("Workplace")]
        public int WorkplaceId { get; set; }
        [Display(Name = "Workplace")]
        public virtual Workplace Workplace { get; set; }
    }
}

