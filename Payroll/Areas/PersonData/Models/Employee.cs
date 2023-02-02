using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PayrollApp.Areas.CalculationData.Models;
using PayrollApp.Areas.EmploymentData.Models;
using PayrollApp.Areas.TaxData.Models;
using PayrollApp.Areas.ThirdParties.Models;

namespace PayrollApp.Areas.PersonData.Models
{
	public class Employee : Person
	{
		public int Id { get; set; }
		public bool HRVI { get; set; }
		public string IBAN { get; set; } = default!;
		public virtual Bank Bank { get; set; } = default!;

		[Display(Name = "Protected IBAN")]
		public string? ProtectedIBAN { get; set; } = default!;

		[Display(Name = "Protected Bank")]
		public virtual Bank? ProtectedBank { get; set; } = default!;

        [Display(Name = "First Employment")]
        public bool FirstEmployment { get; set; }

        [Display(Name = "First Employment With Company")]
        public bool FirstEmploymentWithCompany { get; set; }

		[Display(Name = "Contributions Model")]
        public virtual ContributionsModel ContributionsModel { get; set; } = default!;

		public virtual Contract Contract { get; set; } = default!;

        [Display(Name = "Tax Breaks")]
        public virtual ICollection<TaxBreak> TaxBreaks { get; set; } = default!;
		public virtual ICollection<Dependent> Dependents { get; set; } = default!;
	}
}

