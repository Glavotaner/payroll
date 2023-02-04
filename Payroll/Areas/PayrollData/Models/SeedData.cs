using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Data;

namespace PayrollApp.Areas.PayrollData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<WageParameters>(context.WageParameters, "wage_parameters");
				context.SaveChanges();
			}
		}
	}
}

