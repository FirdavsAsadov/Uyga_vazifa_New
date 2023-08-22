using N29_HT_Task2;


public class Program
{
    static void Main(string[] args)
    {
        ClonableList<StorageFile> clone = new ClonableList<StorageFile>();
        clone.Add(new StorageFile { Name = "File1.txt", Description = "Text file", Size = 1024 });
        clone.Add(new StorageFile { Name = "File2.txt", Description = "Text file", Size = 1025 });
        clone.Add(new StorageFile { Name = "File3.txt", Description = "Text file", Size = 1026 });
        ClonableList<StorageFile> cloneList = (ClonableList<StorageFile>)clone.Clone();
        clone[0].Name = "Modifeid.txt";
        Console.WriteLine("Orginal list: ");
        foreach (StorageFile file in clone)
        {
            Console.WriteLine($"file: {file.Name}\n Description: {file.Description}\n Size: {file.Size}");
        }
        Console.WriteLine("Cloned list: ");
        foreach (StorageFile file in cloneList)
        {
            Console.WriteLine($"file: {file.Name}\n Description: {file.Description}\n Size: {file.Size}");
        }
    }
}