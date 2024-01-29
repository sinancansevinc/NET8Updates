using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET8Updates
{
    public static class ShuffleFeature
    {
        public static void ShuffleCities()
        {
            var cities = CityService.GetCities();

            var cityArray = cities.ToArray();
            Random.Shared.Shuffle(cityArray);

            foreach (var item in cityArray)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Lattiude: {item.Point.Item1} Longitude: {item.Point.Item2}");
            }
        }

    }
}
