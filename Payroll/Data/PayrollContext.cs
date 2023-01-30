using System;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.EmploymentData.Models;
using Payroll.Areas.ThirdParties.Models;

namespace Payroll.Data
{
	public class PayrollContext : DbContext
	{
		public PayrollContext(DbContextOptions<PayrollContext> options) : base(options)
		{
		}
		public DbSet<ContractType> ContractType { get; set; } = default!;
		public DbSet<Workplace> Workplace { get; set; } = default!;
		public DbSet<Contract> Contract { get; set; } = default!;
		public DbSet<Address> Address { get; set; } = default!;
		public DbSet<City> City { get; set; } = default!;
		public DbSet<Bank> Bank { get; set; } = default!;
	}
}

