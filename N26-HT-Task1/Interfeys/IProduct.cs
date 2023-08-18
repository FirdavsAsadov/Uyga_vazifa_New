namespace N26_HT_Task1.Interfeys;

public interface IProduct
{
    public abstract Guid Id { get; set; }
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract bool IsOrdered { get; set; }
    public abstract decimal Price { get; set; }
}