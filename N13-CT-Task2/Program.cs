/*using System.ComponentModel;
var eventlar = new EventManager();
eventlar.Add("BUISNES DAY", new DateOnly(2023, 7, 12));
eventlar.Add("New York day", new DateOnly(2023, 7, 27));
eventlar.Add("Happy Navruz", new DateOnly(2023, 7, 28));
eventlar.Add("JUma", new TimeOnly(7, 30));
eventlar.Add("Payshanba", new TimeOnly(8, 40));
eventlar.Add("Seshanba", new TimeOnly(4, 50));
eventlar.Display();


public class EventManager
{
    public Dictionary<string, DateOnly> kalendarevents = new Dictionary<string, DateOnly>();
    public Dictionary<string, TimeOnly> dailyevents = new Dictionary<string, TimeOnly>();



    public void Add(string name,  DateOnly time) 
    {
        //kalendarevents[name] = time;
        kalendarevents.Add(name, time);
    }

    public void Add(string name, TimeOnly time1)
    {
        dailyevents.Add(name, time1);
    }

    public void Display()
    {
        var nowTime = DateTime.Now;
        var now = new DateOnly(nowTime.Year, nowTime.Month, nowTime.Day);

        foreach(var item in dailyevents)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        foreach(var item2 in kalendarevents)
        {
            if(item2.Value == now.AddDays(1) || item2.Value == now.AddDays(2) || item2.Value == now.AddDays(3))

            Console.WriteLine($"{item2.Key} - {item2.Value}");
        }
    }
}*/








///
/// 
///
///
///

