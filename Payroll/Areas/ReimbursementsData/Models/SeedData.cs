using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Data;

namespace PayrollApp.Areas.ReimbursementsData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<Deductibles>(context.Deductible, "deductibles");
				Seeder.SeedGenericType<Reimbursement>(context.Reimbursement, "reimbursement");
				context.SaveChanges();
			}
		}
	}
}

