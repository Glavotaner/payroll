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
                DateTime validFrom = DateTime.Parse("2020-01-01");
                context.HourTypeCoefficient.AddRange(new HourTypeCoefficient[] {
                    new HourTypeCoefficient {
                        HourType = context.HourType.Find(1)!,
                        Coefficient = 0.5F,
                        ValidFrom = validFrom,
                        },
                    new HourTypeCoefficient {
                        HourType = context.HourType.Find(2)!,
                        Coefficient = 0.5F,
                        ValidFrom = validFrom,
                        },
                    new HourTypeCoefficient {
                        HourType = context.HourType.Find(3)!,
                        Coefficient = 0.5F,
                        ValidFrom = validFrom,
                        },
                });
                context.SaveChanges();
            }
        }
    }
}

