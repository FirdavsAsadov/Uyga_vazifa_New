public class prgram
{
    static void Main()
    {
       var  plannerA = new UltimatePlanner();
       
        plannerA.Add("timeday", time: new TimeOnly(7, 30));
        plannerA.Add("timeday2", time: new TimeOnly(7, 30));
        plannerA.Add("timeday3", time: new TimeOnly(8, 30));
        plannerA.Add("kalendar1", new DateOnly(2023, 1, 1));
        plannerA.Add("kalendar2", new DateOnly(2023, 1, 2));
        plannerA.Add("kalendar3", new DateOnly(2023, 1, 3));

        plannerA.Display();

    }
}



public class Planner
{
     public Dictionary<string, TimeOnly> events = new Dictionary<string, TimeOnly>();
    public virtual void Add(string name, TimeOnly time)
    {
        events[name] = time;
    }

    public virtual void Display()
    {
        foreach(var item in events)
        {
            Console.WriteLine(item);
        }
    }
}

public class UltimatePlanner : Planner
{
    Dictionary<string, DateOnly> kalendarevents = new Dictionary<string, DateOnly>();
    public override void Add(string name, TimeOnly time)
    {
        var hasconf = false;
        foreach(var item in events)
        {
            if (item.Value.Hour == time.Hour)
            {
                hasconf = true;
                Console.WriteLine("You have conflict in daily plan");
            }
        }


        if (!hasconf)
        {
            events[name] = time;
        }
    }
    
    public void Add(string name, DateOnly time)
    {
        kalendarevents[name] = time;
    }

    public override void Display()
    {
        foreach(var item2 in kalendarevents)
        {
            Console.WriteLine(item2);
        }

        base.Display();
    }

}