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
                DateTime validFrom = DateTime.Parse("2020-01-01");
                context.ReimbursementValue.AddRange(new ReimbursementValue[] {
                    new ReimbursementValue {
                        Reimbursement = context.Reimbursement.Find(1)!,
                        Value = 500,
                        ValidFrom = validFrom,
                    },
                    new ReimbursementValue {
                        Reimbursement = context.Reimbursement.Find(2)!,
                        Value = 500,
                        ValidFrom = validFrom,
                    },
                    new ReimbursementValue {
                        Reimbursement = context.Reimbursement.Find(3)!,
                        Value = 500,
                        ValidFrom = validFrom,
                    },
                });
                context.SaveChanges();
            }
        }
    }
}

