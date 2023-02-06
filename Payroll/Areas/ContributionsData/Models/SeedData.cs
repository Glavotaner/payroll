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
                DateTime validFrom = DateTime.Parse("2018-01-01");
                context.ContributionRate.AddRange(new ContributionRate[] {
                    new ContributionRate() {
                        Contribution = context.Contribution.Find(1)!,
                        Rate = 15,
                        ValidFrom = validFrom,
                    },
                    new ContributionRate() {
                        Contribution = context.Contribution.Find(1)!,
                        Rate = 20,
                        ValidFrom = validFrom,
                    },
                    new ContributionRate() {
                        Contribution = context.Contribution.Find(3)!,
                        Rate = 5,
                        ValidFrom = validFrom,
                    },
                    new ContributionRate() {
                        Contribution = context.Contribution.Find(4)!,
                        Rate = 16.5F,
                        ValidFrom = validFrom,
                    },
                    new ContributionRate() {
                        Contribution = context.Contribution.Find(4)!,
                        Rate = 0.5F,
                        ValidFrom = validFrom,
                    }
                });
                var contributionsWithIds = (int[] ids) => context
                .ContributionRate.Where(c => ids.Contains(c.Id)).ToList();
                context.ContributionsModel.AddRange(new ContributionsModel[] {
                    new ContributionsModel {
                        Name = "REG",
                        ContributionRates = contributionsWithIds(
                            new int[] {1,3,4})
                    },
                    new ContributionsModel {
                        Name = "NOIND",
                        ContributionRates = contributionsWithIds(
                            new int[] {2,4})
                    },
                    new ContributionsModel {
                        Name = "Y30",
                        ContributionRates = contributionsWithIds(
                            new int[] {1,3})
                    },
                });
                context.SaveChanges();
            }
        }
    }
}

