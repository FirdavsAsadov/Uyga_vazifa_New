namespace N29_HT_Task1;

public class Event : IEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Event(string name, DateTime date)
    {
        Id = Guid.NewGuid();
        Name = name;
        Date = date;
    }
    
}
    
