using N26_HT_Task1.Interfeys;

namespace N26_HT_Task1.Model;

public class Monitor : IProduct
{
    public Monitor(int refreshRate,double displaySize,string name, string description, bool isOrdered, decimal price) 
    {
        Id = Guid.NewGuid();
        RefreshRate = refreshRate;
        DisplaySize = displaySize;
    }

    public Monitor(Monitor monitor)
    {
        Price = monitor.Price;
        IsOrdered = monitor.IsOrdered;
        Description = monitor.Description;
        Name = monitor.Name;
        Id = monitor.Id;
        RefreshRate = monitor.RefreshRate;
        DisplaySize = monitor.DisplaySize;
    }

    public  Guid Id { get; set; }
    public  string Name { get; set; }
    public  string Description { get; set; }
    public  bool IsOrdered { get; set; }
    public  decimal Price { get; set; }
    public int RefreshRate { get; set; }
    public double DisplaySize { get; set; }
}