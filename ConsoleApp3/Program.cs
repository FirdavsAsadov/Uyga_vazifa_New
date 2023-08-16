using System.Diagnostics.Metrics;
using System.Text.Json;
using ConsoleApp3;

string savepath = @"C:\Users\Acer\Desktop\AllCountries.txt";
var jsonFile = File.ReadAllText(savepath);
var result  = JsonSerializer.Deserialize<List<Country>>(jsonFile);
result.DistinctBy(country => country.Region).ToList().ForEach(country =>Console.WriteLine(country.Region));

Console.WriteLine("1-Asia\n2-Africa\n3-Europe\n4-Americas\n5-Oceania\n6-Antarctic");
while (true)
{
    Console.WriteLine("Berilgan Region dan bittasini Tanlang: ");
    string region = Console.ReadLine();
    switch (region)
    {
        case "1":
            region = "Asia";
            break;
        case "2":
            region = "Africa";
            break;
        case "3":
            region = "Europe";
            break;
        case "4":
            region = "Americas";
            break;
        case "5":
            region = "Oceania";
            break;
        case "6":
            region = "Antarctic";
            break;
        
    }
        result.Where(country => country.Region == region).ToList().ForEach(country =>Console.WriteLine($"{country.Name.Common} - {country.Flag.Png}"));

}