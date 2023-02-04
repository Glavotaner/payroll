using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Data;

namespace PayrollApp.Areas.HoursData.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<HoursFund>(context.HoursFund, "hours_fund");
				Seeder.SeedGenericType<HourType>(context.HourType, "hour_type");
				context.SaveChanges();
			}
		}
	}
}

