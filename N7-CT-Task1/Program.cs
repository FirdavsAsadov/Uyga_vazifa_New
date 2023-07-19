using System.Globalization;

var started = new TimeOnly(8, 30);
var end = new TimeOnly(18, 30);
string[] metinglar =  new string[10];
metinglar[0] = "1-meting";
metinglar[1] = "2-meting";
metinglar[2] = "3-meting";
metinglar[3] = "4-meting";
metinglar[4] = "5-meting";
metinglar[5] = "6-meting";
metinglar[6] = "7-meting";
metinglar[7] = "8-mting";
metinglar[8] = "9-meting";
metinglar[9] = "10-meting";
DateTime[] boshlanishi = new DateTime[10];
boshlanishi[0] = new DateTime(2023, 12, 1, 6, 40, 00);
boshlanishi[1] = new DateTime(2023, 12, 2, 15, 30, 00);
boshlanishi[2] = new DateTime(2023, 12, 3, 5, 20, 00);
boshlanishi[3] = new DateTime(2023, 12, 4, 11, 10, 00);
boshlanishi[4] = new DateTime(2023, 12, 5, 13, 20, 00);
boshlanishi[5] = new DateTime(2023, 12, 6, 21, 40, 00);
boshlanishi[6] = new DateTime(2023, 12, 7, 17, 10, 00);
boshlanishi[7] = new DateTime(2023, 12, 1, 20, 00, 00);
boshlanishi[8] = new DateTime(2023, 12, 2, 14, 5, 00);
boshlanishi[9] = new DateTime(2023, 12, 3, 22, 30, 00);

TimeSpan[] During = new TimeSpan[]
{
    TimeSpan.FromMinutes(30),
    TimeSpan.FromMinutes(40),
    TimeSpan.FromMinutes(50),
    TimeSpan.FromMinutes(20),
    TimeSpan.FromMinutes(10),
    TimeSpan.FromMinutes(15),
    TimeSpan.FromMinutes(70),
    TimeSpan.FromMinutes(80),
    TimeSpan.FromMinutes(55),
    TimeSpan.FromMinutes(35),

};
for(int i = 0; i < metinglar.Length; i++)
{
    DateTime metingStart = boshlanishi[i];
    DateTime metingend = boshlanishi[i].Add(During[i]);
    if(TimeOnly.FromDateTime(metingStart) > started && TimeOnly.FromDateTime(metingend) > end)
    {
        Console.WriteLine($"BAD METING {metinglar[i]}");
    }
}
var maxmeting = During.Max();
Console.WriteLine($"Eng kop bolgan meting {maxmeting}");
var minmeting = During.Min();
Console.WriteLine($"Eng kam bolgan meting {minmeting}");



for (int i = 0; i < During.Length; i++)
{
    if (During[i].TotalMinutes > 30)
    {
        Console.WriteLine($"{metinglar[i]} - {During[i]}");
    }
}

