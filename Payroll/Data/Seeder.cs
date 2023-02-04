using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace PayrollApp.Data
{ 
	public static class Seeder
    {
        public static void SeedGenericType<T>(DbSet<T> dbSet, string jsonName) where T : class
        {
            if (dbSet.Any()) return;

            IEnumerable<T> data = DeserializeSeed<T>(jsonName);
            dbSet.AddRange(data);
        }

        public static IEnumerable<T> DeserializeSeed<T>(string jsonName)
        {
            string json = File.ReadAllText($"Data/Seed/{jsonName}.json");
            IEnumerable<T> data = JsonSerializer.Deserialize<IEnumerable<T>>(json)!;
            return data;
        }
    }
}
