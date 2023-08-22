namespace N29_HT_Task1;

public interface IEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    
}