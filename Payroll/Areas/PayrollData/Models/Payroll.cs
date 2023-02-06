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
        [DataType(DataType.Date)]
        public DateTime AccountingDate { get; set; }

        public virtual Labour Labour { get; set; } = default!;

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float Wage { get; set; }

        [Display(Name = "Gross Salary")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float GrossSalary { get; set; }

        [Display(Name = "Contributions Base")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float ContributionsBase { get; set; }

        // TODO make virtual
        [Display(Name = "Contributions From Pay")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float ContributionsFromPay { get; set; }

        // TODO make virtual
        [Display(Name = "Contributions Other")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float ContributionsOther { get; set; }

        [Display(Name = "Contribution Amounts")]
        public virtual ICollection<ContributionAmount> ContributionAmounts { get; set; } = default!;

        [Display(Name = "Income")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float Income { get; set; }

        [Display(Name = "Personal Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float PersonalDeductible { get; set; }

        [Display(Name = "Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float DependentsDeductible { get; set; }

        [Display(Name = "Partially Disabled Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float DependentsDisabledPartialDeductible { get; set; }

        [Display(Name = "Fully Disabled Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float DependentsDisabledFullDeductible { get; set; }

        [Display(Name = "Child Dependents Deductible")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float DependentsChildrenDeductible { get; set; }

        [Display(Name = "Tax Base"), DataType(DataType.Currency)]
        public float TaxBase { get; set; }

        [Display(Name = "Income Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float IncomeTaxAmount { get; set; }

        [Display(Name = "City Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float CityTaxAmount { get; set; }

        [Display(Name = "Tax Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float TaxAmount { get; set; }

        [Display(Name = "Net Salary")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float NetSalary { get; set; }

        // TODO make virtual
        [Display(Name = "Reimbursement Amount")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float ReimbursementsAmount { get; set; }

        [Display(Name = "Reimbursement Amounts")]
        public virtual ICollection<ReimbursementAmount> ReimbursementAmounts { get; set; } = default!;

        [Display(Name = "Labour Cost")]
        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public float LabourCost { get; set; }
    }
}

