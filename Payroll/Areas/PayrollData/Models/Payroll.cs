using System;
using System.ComponentModel.DataAnnotations;
using Payroll.Areas.CalculationData.Models;

namespace Payroll.Areas.PayrollData.Models
{
	public class Payroll
	{
		public int Id { get; set; }
		public int Counter { get; set; }

		[Display(Name = "Accounting Date")]
		[DataType(DataType.Date)]
		public DateTime AccountingDate { get; set; }

		public int Year { get; set; }
		public int Month { get; set; }
		public virtual Labour Labour { get; set; }
		public virtual ICollection<Contribution> Contributions { get; set; }
		public float Wage { get; set; }

		[Display(Name = "Gross Salary")]
		public float GrossSalary { get; set; }

        [Display(Name = "Contributions Base")]
        public float ContributionsBase { get; set; }

        [Display(Name = "Contributions From Pay")]
        public float ContributionsFromPay { get; set; }

        [Display(Name = "Contributions Other")]
        public float ContributionsOther { get; set; }

        [Display(Name = "Contribution Amounts")]
        public virtual ICollection<ContributionAmount> ContributionAmounts { get; set; }

        [Display(Name = "Income")]
        public float Income { get; set; }

        [Display(Name = "Personal Deductible")]
        public float PersonalDeductible { get; set; }

        [Display(Name = "Dependents Deductible")]
        public float DependentsDeductible { get; set; }

        [Display(Name = "Partially Disabled Dependents Deductible")]
        public float DependentsDisabledPartialDeductible { get; set; }

        [Display(Name = "Fully Disabled Dependents Deductible")]
        public float DependentsDisabledFullDeductible { get; set; }

        [Display(Name = "Child Dependents Deductible")]
        public float DependentsChildrenDeductible { get; set; }

        [Display(Name = "Tax Base")]
        public float TaxBase { get; set; }

        [Display(Name = "Income Tax Amount")]
        public float IncomeTaxAmount { get; set; }

        [Display(Name = "City Tax Amount")]
        public float CityTaxAmount { get; set; }

        [Display(Name = "Tax Amount")]
        public float TaxAmount { get; set; }

        [Display(Name = "Net Salary")]
        public float NetSalary { get; set; }

        [Display(Name = "Reimbursement Amount")]
        public float ReimbursementsAmount { get; set; }

        [Display(Name = "Reimbursement Amounts")]
        public virtual ICollection<ReimbursementAmount> ReimbursementAmounts { get; set; }

        [Display(Name = "Labour Cost")]
        public float LabourCost { get; set; }
	}
}

