using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.CalculationData.Models;

namespace PayrollApp.Areas.PayrollData.Models
{
    public class Payroll
    {
        public int Id { get; set; }

        [Range(1, 100)]
        public int Counter { get; set; }

        [Display(Name = "Accounting Date")]
        [DataType(DataType.Date), Column(TypeName = "date")]
        public DateTime AccountingDate { get; set; }

        public virtual Labour Labour { get; set; } = default!;

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Wage { get; set; }

        [Display(Name = "Gross Salary")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal GrossSalary { get; set; }

        [Display(Name = "Contributions Base")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal ContributionsBase { get; set; }

        [Display(Name = "Contributions From Pay")]
        [DataType(DataType.Currency)]
        [NotMapped]
        public decimal ContributionsFromPay
        {
            get => (from contribution in ContributionAmounts
                    where contribution.Contribution.FromPay
                    select contribution.Amount).Sum();
        }

        [Display(Name = "Contributions Other")]
        [DataType(DataType.Currency)]
        [NotMapped]
        public decimal ContributionsOther
        {
            get => (from contribution in ContributionAmounts
                     where !contribution.Contribution.FromPay
                     select contribution.Amount).Sum();
        }

        [Display(Name = "Contribution Amounts")]
        public virtual ICollection<ContributionAmount> ContributionAmounts { get; set; } = default!;

        [Display(Name = "Income")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Income { get; set; }

        [Display(Name = "Personal Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal PersonalDeductible { get; set; }

        [Display(Name = "Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal DependentsDeductible { get; set; }

        [Display(Name = "Partially Disabled Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal DependentsDisabledPartialDeductible { get; set; }

        [Display(Name = "Fully Disabled Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal DependentsDisabledFullDeductible { get; set; }

        [Display(Name = "Child Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal DependentsChildrenDeductible { get; set; }

        [Display(Name = "Tax Base")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal TaxBase { get; set; }

        [Display(Name = "Income Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal IncomeTaxAmount { get; set; }

        [Display(Name = "City Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal CityTaxAmount { get; set; }

        [Display(Name = "Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal TaxAmount { get; set; }

        [Display(Name = "Net Salary")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal NetSalary { get; set; }

        [Display(Name = "Reimbursement Amount")]
        [DataType(DataType.Currency)]
        [NotMapped]
        public decimal ReimbursementsAmount {
            get => (from reimbursement in ReimbursementAmounts
                    select reimbursement.Amount).Sum();
        }

        [Display(Name = "Reimbursement Amounts")]
        public virtual ICollection<ReimbursementAmount> ReimbursementAmounts { get; set; } = default!;

        [Display(Name = "Labour Cost")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal LabourCost { get; set; }
    }
}

