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
                if (!context.TaxModel.Any())
                {
                    context.TaxModel.AddRange(new TaxModel[] {
                        new TaxModel {
                        TaxBrackets = context.TaxBracket.Where(b => b.Id < 3).ToList(),
                        ValidFrom = DateTime.Parse("2021-01-01"),
                    },
                    new TaxModel {
                        TaxBrackets = context.TaxBracket.Where(b => b.Id > 2).ToList(),
                        ValidFrom = DateTime.Parse("2018-01-01"),
                    }
                });
                }
                context.SaveChanges();
            }
        }
    }
}

