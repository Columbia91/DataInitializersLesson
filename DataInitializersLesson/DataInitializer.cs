using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInitializersLesson
{
    public class DataInitializer : CreateDatabaseIfNotExists<CitiesContext>
    {
        protected override void Seed(CitiesContext context)
        {
            context.Cities.AddRange(new List<City>
            {
                new City
                {
                    Name = "Нур-Султан",
                    Population = 1200000
                },
                new City
                {
                    Name = "Алматы",
                    Population = 2000000
                },
                new City
                {
                    Name = "Стамбул",
                    Population = 15000000
                }
            });
        }
    }
}
