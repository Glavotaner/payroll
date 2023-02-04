using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.CalculationData.Models;
using PayrollApp.Data;

namespace PayrollApp.Areas.ContributionsData.Models
{
    public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PayrollContext(serviceProvider
				.GetRequiredService<DbContextOptions<PayrollContext>>()))
			{
				Seeder.SeedGenericType<Contribution>(context.Contribution, "contribution");
				context.SaveChanges();
            }
		}
	}
}

