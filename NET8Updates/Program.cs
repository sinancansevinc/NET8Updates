
using NET8Updates;

var cities = new List<City>
{
    new City(34,"İstanbul",("45.2342.324",42.479)),
    new City(35,"İzmir",("41.2342.324",47.479)),
    new City(6,"Ankara",("45.2342.324",46.479)),
    new City(16,"Bursa",("43.2142.324",48.479)),
    new City(42,"Konya",("38.2342.324",49.479)),

};

var cityArray = cities.ToArray();
Random.Shared.Shuffle(cityArray);

foreach (var item in cityArray)
{
    Console.WriteLine($"Id: {item.Id} Name: {item.Name} Lattiude: {item.Point.Item1} Longitude: {item.Point.Item2}");
}



Console.ReadLine();

