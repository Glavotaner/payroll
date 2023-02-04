using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Data;

namespace PayrollApp.Areas.EmploymentData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<Workplace>(context.Workplace, "workplace");
				Seeder.SeedGenericType<ContractType>(context.ContractType, "contract_type");
				context.SaveChanges();
			}
		}
	}
}

