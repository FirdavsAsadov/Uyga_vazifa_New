using N26_HT_Task1.Interfeys;

namespace N26_HT_Task1.Model;

public class Chair : IProduct
{
    public  Guid Id { get; set; }
    public  string Name { get; set; }
    public  string Description { get; set; }
    public  bool IsOrdered { get; set; }
    public decimal Price { get; set; }
    public int MaxWeight { get; set; }
    public string Material { get; set; }
    public Chair(int maxWeight, string material, string name, string description,bool isOrdered, decimal price)
    {
        Id  = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        MaxWeight = maxWeight;
        Material = material;
    }

    public Chair(Chair chair)
    {
        Id = chair.Id;
        Name = chair.Name;
        Description = chair.Description;
        IsOrdered = chair.IsOrdered;
        Price = chair.Price;
        MaxWeight = chair.MaxWeight;
        Material = chair.Material;
    }
}