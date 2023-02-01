using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Payroll.Areas.CalculationData.Models;
using Payroll.Areas.EmploymentData.Models;
using Payroll.Areas.TaxData.Models;
using Payroll.Areas.ThirdParties.Models;

namespace Payroll.Areas.PersonData.Models
{
	public class Employee : Person
	{
		public int Id { get; set; }
		public bool HRVI { get; set; }
		public string IBAN { get; set; }
		public virtual Bank Bank { get; set; }

		[Display(Name = "Protected IBAN")]
		public string? ProtectedIBAN { get; set; }

		[Display(Name = "Protected Bank")]
		public virtual Bank? ProtectedBank { get; set; }

        [Display(Name = "First Employment")]
        public bool FirstEmployment { get; set; }

        [Display(Name = "First Employment With Company")]
        public bool FirstEmploymentWithCompany { get; set; }

		[Display(Name = "Contributions Model")]
        public virtual ContributionsModel ContributionsModel { get; set; }

		public virtual Contract Contract { get; set; }

        [Display(Name = "Tax Breaks")]
        public virtual ICollection<TaxBreak> TaxBreaks { get; set; }
		public virtual ICollection<Dependent> Dependents { get; set; }
	}
}

