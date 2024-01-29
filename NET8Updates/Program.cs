
using NET8Updates;

ShuffleFeature.ShuffleCities();
var getFullName = (string firstName, string lastName = "Sevinç") => string.Join(" ", firstName, lastName);

var primaryUser = getFullName("Sino");
var secondUser = getFullName("Sino", "Mino");


Console.WriteLine(primaryUser);
Console.WriteLine(secondUser);

Console.ReadLine();