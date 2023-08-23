using System.Text;

List<string> userNames = new List<string>();
userNames.Add("John");
userNames.Add("Mary");
userNames.Add("Peter");
userNames.Add("Johny");
userNames.Add("Maryjon");
var createdFile = userNames.Select(user => Task.Run(() =>
{

    var fileStream = File.Create($"{user.ToLower()}.docx");
    Console.WriteLine($"{user} ga fayl yaratildi");
    return fileStream;
}));

var userFiles = (await Task.WhenAll(createdFile)).ToList();
var writeFiles = userFiles.Select(file =>
{
    var message = $"Hurmatli {file.Name}, blah blah blah";
    return file.WriteAsync(Encoding.UTF8.GetBytes(message));
});

 






















