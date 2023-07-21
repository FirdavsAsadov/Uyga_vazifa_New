var events =new List<string>();
events.Add("Navruz");
events.Add("QodirAli ning Tavallud Ayyomi");
events.Add("NT ochilish marosimi");
events.Add("Najot Quiz");
events.Add("Dostlar Kuni");

var country = new List<string>();
country.Add("uz");
country.Add("ru");
country.Add("eng");

DateTime[] Times = new DateTime[5];
Times[0] = new DateTime(2023, 12, 1, 6, 40, 00);
Times[1] = new DateTime(2023, 12, 2, 15, 30, 00);
Times[2] = new DateTime(2023, 12, 3, 5, 20, 00);
Times[3] = new DateTime(2023, 12, 4, 11, 10, 00);
Times[4] = new DateTime(2023, 12, 5, 13, 20, 00);
var temp = default(DateTime);
var Tempname = default(string);
for(var indexA = 0; indexA < 6 - 1; indexA ++)
    for(var indexB = indexA + 1; indexB < 6 - 1; indexB++)
        if (Times[indexA].DayOfYear < Times[indexB].DayOfYear)
        {
            temp = Times[indexA];
            Times[indexA] = Times[indexB];
            Times[indexB] = temp;

            Tempname = events[indexA];
            events[indexA] = events[indexB];
            events[indexB] = Tempname;
        }

foreach (var countrycode in country)
{
    switch (countrycode)
    {
        case "uz":
            Console.WriteLine(countrycode);
            for(var vaqt = 0;vaqt < Times.Length; vaqt++)
            {
                Console.WriteLine($"{events[vaqt]} - {Times[vaqt].ToString("dd.MM.yyyy hh:mm")}");
            }
            break;
        case "eng":
            Console.WriteLine(countrycode);
            for(var vaqt = 0;vaqt< Times.Length; vaqt++)
            {
                Console.WriteLine($"{events[vaqt]} - {Times[vaqt].ToString("dd.MM.yyyy HH:mm tt" )}");
            }
            break;
        case "ru":
            Console.WriteLine(countrycode);
            for( var vaqt = 0;vaqt < Times.Length; vaqt++)
            {
                Console.WriteLine($"{events[vaqt]} - {Times[vaqt].ToString("dd/MM/yyyy HH:mm")}");
            }
            break;
    }
}