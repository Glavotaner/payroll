using System;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.CalculationData.Models;
using PayrollApp.Areas.EmploymentData.Models;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Areas.PayrollData.Models;
using PayrollApp.Areas.PersonData.Models;
using PayrollApp.Areas.ReimbursementsData.Models;
using PayrollApp.Areas.TaxData.Models;
using PayrollApp.Areas.ThirdParties.Models;

namespace PayrollApp.Data
{
	public class PayrollContext : DbContext
	{
		public PayrollContext(DbContextOptions<PayrollContext> options) : base(options)
		{
		}
        public DbSet<Contribution> Contribution { get; set; } = default!;
        public DbSet<ContributionRate> ContributionRate { get; set; } = default!;
        public DbSet<ContributionsModel> ContributionsModel { get; set; } = default!;
        public DbSet<Contract> Contract { get; set; } = default!;
        public DbSet<ContractType> ContractType { get; set; } = default!;
        public DbSet<Workplace> Workplace { get; set; } = default!;
        public DbSet<HourType> HourType { get; set; } = default!;
        public DbSet<HourTypeCoefficient> HourTypeCoefficient { get; set; } = default!;
        public DbSet<HoursFund> HoursFund { get; set; } = default!;
        public DbSet<ContributionAmount> ContributionAmount { get; set; } = default!;
        public DbSet<HourTypeAmount> HourTypeAmount { get; set; } = default!;
        public DbSet<Labour> Labour { get; set; } = default!;
        public DbSet<Payroll> Payroll { get; set; } = default!;
        public DbSet<ReimbursementAmount> ReimbursementAmount { get; set; } = default!;
        public DbSet<WageParameters> WageParameters { get; set; } = default!;
        public DbSet<Dependent> Dependent { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Deductibles> Deductible { get; set; } = default!;
        public DbSet<Reimbursement> Reimbursement { get; set; } = default!;
        public DbSet<ReimbursementValue> ReimbursementValue { get; set; } = default!;
        public DbSet<TaxBracket> TaxBracket { get; set; } = default!;
        public DbSet<TaxBreak> TaxBreak { get; set; } = default!;
        public DbSet<TaxModel> TaxModel { get; set; } = default!;
        public DbSet<Street> Address { get; set; } = default!;
        public DbSet<Bank> Bank { get; set; } = default!;
        public DbSet<City> City { get; set; } = default!;
    }
}

