using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Data;

namespace PayrollApp.Areas.TaxData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<TaxBracket>(context.TaxBracket, "tax_bracket");
				Seeder.SeedGenericType<TaxBreak>(context.TaxBreak, "tax_break");
				context.SaveChanges();
			}
		}
	}
}

