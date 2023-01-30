using System;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.EmploymentData.ContractType.Models;
using Payroll.Areas.EmploymentData.Workplace.Models;
using Payroll.Areas.EmploymentData.Contract.Models;

namespace Payroll.Data
{
	public class PayrollContext : DbContext
	{
		public PayrollContext(DbContextOptions<PayrollContext> options) : base(options)
		{
		}
		public DbSet<Payroll.Areas.EmploymentData.ContractType.Models.ContractType> ContractType { get; set; } = default!;
		public DbSet<Payroll.Areas.EmploymentData.Workplace.Models.Workplace> Workplace { get; set; } = default!;
		public DbSet<Payroll.Areas.EmploymentData.Contract.Models.Contract> Contract { get; set; } = default!;
	}
}

