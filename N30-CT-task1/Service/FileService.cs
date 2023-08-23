using System.Text.Json;

namespace N30_CT_task1.Service;

public class FileService<T>
{
    private List<T> list;
    private string fileName = $"{nameof(T)}.json";
    public static string path = "";
    private string filePath = Path.Combine();

    public void Add(List<T> values)
    {
        var jsonData = JsonSerializer.Deserialize<List<T>>(File.ReadAllText((path)));
        
        jsonData.AddRange(values);
        
        File.WriteAllText((path), JsonSerializer.Serialize(jsonData));
    }
}