using System;
using System.ComponentModel.DataAnnotations;
using PayrollApp.Areas.CalculationData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
	public class Payroll
	{
		public int Id { get; set; }

        [Range(1, 100)]
		public int Counter { get; set; }

		[Display(Name = "Accounting Date"), DataType(DataType.Date)]
		public DateTime AccountingDate { get; set; }

		[Range(2022, 9999)]
		public int Year { get; set; }

		[Range(1, 12)]
		public int Month { get; set; }
		public virtual Labour Labour { get; set; } = default!;
		public virtual ICollection<Contribution> Contributions { get; set; } = default!;
		
        [DataType(DataType.Currency)]
        public float Wage { get; set; }

		[Display(Name = "Gross Salary"), DataType(DataType.Currency)]
		public float GrossSalary { get; set; }

        [Display(Name = "Contributions Base"), DataType(DataType.Currency)]
        public float ContributionsBase { get; set; }

        // TODO make virtual
        [Display(Name = "Contributions From Pay"), DataType(DataType.Currency)]
        public float ContributionsFromPay { get; set; }

        // TODO make virtual
        [Display(Name = "Contributions Other"), DataType(DataType.Currency)]
        public float ContributionsOther { get; set; }

        [Display(Name = "Contribution Amounts")]
        public virtual ICollection<ContributionAmount> ContributionAmounts { get; set; } = default!;

        [Display(Name = "Income"), DataType(DataType.Currency)]
        public float Income { get; set; }

        [Display(Name = "Personal Deductible"), DataType(DataType.Currency)]
        public float PersonalDeductible { get; set; }

        [Display(Name = "Dependents Deductible"), DataType(DataType.Currency)]
        public float DependentsDeductible { get; set; }

        [Display(Name = "Partially Disabled Dependents Deductible"), DataType(DataType.Currency)]
        public float DependentsDisabledPartialDeductible { get; set; }

        [Display(Name = "Fully Disabled Dependents Deductible"), DataType(DataType.Currency)]
        public float DependentsDisabledFullDeductible { get; set; }

        [Display(Name = "Child Dependents Deductible"), DataType(DataType.Currency)]
        public float DependentsChildrenDeductible { get; set; }

        [Display(Name = "Tax Base"), DataType(DataType.Currency)]
        public float TaxBase { get; set; }

        [Display(Name = "Income Tax Amount"), DataType(DataType.Currency)]
        public float IncomeTaxAmount { get; set; }

        [Display(Name = "City Tax Amount"), DataType(DataType.Currency)]
        public float CityTaxAmount { get; set; }

        [Display(Name = "Tax Amount"), DataType(DataType.Currency)]
        public float TaxAmount { get; set; }

        [Display(Name = "Net Salary"), DataType(DataType.Currency)]
        public float NetSalary { get; set; }

        // TODO make virtual
        [Display(Name = "Reimbursement Amount"), DataType(DataType.Currency)]
        public float ReimbursementsAmount { get; set; }

        [Display(Name = "Reimbursement Amounts")]
        public virtual ICollection<ReimbursementAmount> ReimbursementAmounts { get; set; } = default!;

        [Display(Name = "Labour Cost"), DataType(DataType.Currency)]
        public float LabourCost { get; set; }
	}
}

