using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cities = System.Collections.Generic.List<NET8Updates.City>;

namespace NET8Updates
{
    public static class CityService
    {
        public static Cities GetCities()
        {

            var cities = new List<City>
            {
                new City(34,"İstanbul",("45.2342.324",42.479)),
                new City(35,"İzmir",("41.2342.324",47.479)),
                new City(6,"Ankara",("45.2342.324",46.479)),
                new City(16,"Bursa",("43.2142.324",48.479)),
                new City(42,"Konya",("38.2342.324",49.479)),

            };

            return cities;

        }
    }
}
