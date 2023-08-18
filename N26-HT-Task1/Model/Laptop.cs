using N26_HT_Task1.Interfeys;

namespace N26_HT_Task1.Model;

public class Laptop : IProduct
{
    public Laptop(string cpuBrand,string cpuModel,string name, string description, bool isOrdered, decimal price)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        IsOrdered = isOrdered;
        CpuBrand = cpuBrand;
        CpuModel = cpuModel;
    }

    public Laptop(Laptop laptop)
    {
        Name = laptop.Name;
        Description = laptop.Description;
        Price = laptop.Price;
        IsOrdered = laptop.IsOrdered;
        CpuBrand = laptop.CpuBrand;
        CpuModel = laptop.CpuModel;
        
    }

    public  Guid Id { get; set; }
    public  string Name { get; set; }
    public  string Description { get; set; }
    public  bool IsOrdered { get; set; }
    public  decimal Price { get; set; }
    public string CpuBrand { get; set; }
    public string CpuModel { get; set; }
}