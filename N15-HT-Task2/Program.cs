using static WheatherReportServer;

public class Program
{
    static void Main()
    {
        UltimateWeatherReport ultimateWeatherReport = new UltimateWeatherReport();
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now), "Sunniy");
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now), "Rainy");
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now.AddDays(value: 1)), "Iliq");
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now.AddDays(value: 12)), "Bulutli");
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now.AddDays(value: 3)), "Sovuq");
        ultimateWeatherReport.Add(DateOnly.FromDateTime(DateTime.Now.AddDays(value: 4)), "Jazirama");
        DateOnly specificDate = DateOnly.FromDateTime(DateTime.Now.AddDays(4));

        Console.WriteLine($"Ob-Havo {specificDate} : {ultimateWeatherReport.Get(specificDate)}");
        int numberOfDays = 5;
        Console.WriteLine($"5 kunlik ob-havo {numberOfDays} kunlar: {ultimateWeatherReport.Get(numberOfDays)}");
    }
}
public class WheatherReportServer
{
    protected Dictionary<DateOnly, string> weatherinformationlist = new Dictionary<DateOnly, string>();
    public WheatherReportServer()
    {

    }

    public string Get(DateOnly dates)
    {
        return Find(dates) == null ? "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring" : Find(dates);
    }

    public string Find(DateOnly dates)
    {
        foreach (var item in weatherinformationlist)
        {
            if (dates == item.Key)
            {
                return item.Value;
            }
        }
        return null;
    }

    public virtual void Add(DateOnly dates, string obhavo)
    {
        try
        {
            if (dates < DateOnly.FromDateTime(DateTime.Now))
                throw new Exception("Eski ob havo kiritma");
            else
                weatherinformationlist[dates] = obhavo;
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp.Message);
        }
    }


    public class ValidatedWeahterReport : WheatherReportServer
    {
        public ValidatedWeahterReport()
        {

        }
        public override void Add(DateOnly date, string obhavo)
        {
            if(Find(date) != null)
            {
                weatherinformationlist[date] = obhavo;
            }
            else
            {
                base.Add(date, obhavo);
            }
        }

    }
}


public class UltimateWeatherReport : ValidatedWeahterReport
{
    public string Get(DateOnly startDate, int numberOfDays)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < numberOfDays; i++)
        {
            DateOnly currentDates = startDate.AddDays(i);
            string weather = Find(currentDates);
            result.Add(weather != null ? weather : "Uzr To'liq Ma'lumot yo'q");
        }
        return string.Join(", ", result);
    }

    public string Get(int numberOfDays)
    {
        return Get(DateOnly.FromDateTime(DateTime.Now), numberOfDays);
    }

}




