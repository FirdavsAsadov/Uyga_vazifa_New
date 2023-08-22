namespace N29_HT_Task2;

public class StorageFile : ICloneable
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Size { get; set; }
    public object Clone()
    {
        return new StorageFile()
        {
            Id = this.Id,
            Name = this.Name,
            Description = this.Description,
            Size = this.Size
        };
    }
}