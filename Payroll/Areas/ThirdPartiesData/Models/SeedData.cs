using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HoursData.Models;
using PayrollApp.Areas.ThirdParties.Models;
using PayrollApp.Data;

namespace PayrollApp.Areas.ThirdPartiesData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<City>(context.City, "city");
				context.SaveChanges();
			}
		}
	}
}

