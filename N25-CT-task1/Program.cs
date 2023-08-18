using N25_CT_task1;
using System.Text.Json;

string path = @"D:\person\jerson.txt";

/*StreamReader reader = new StreamReader(path);
var readw = reader.ReadToEnd();
reader.Close();*/
var userList = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText((path)));
//streamReader.Close();
while (true)
{
    Console.WriteLine("1-Add\n2-Read\n3-Update\n4-Delete");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("enter name");
            var name = Console.ReadLine();
            Console.WriteLine("enter age");
            var age = Console.ReadLine();
            userList.Add(new Person(userList.Last().Id + 1, name, int.Parse(age)));
            break;
        case 2:
            userList.ForEach(x => Console.WriteLine($"{x.Id} - {x.Name} - {x.Age}"));
            break;
        case 3:
            Console.WriteLine("enter id");
            var id1 = Console.ReadLine();
            Console.WriteLine("enter name");
            var name1 = Console.ReadLine();
            Console.WriteLine("enter age");
            var age1 = Console.ReadLine();
            userList.ForEach(z =>
            {
                if (z.Id == int.Parse(id1))
                {
                    z.Name = name1;
                    z.Age = int.Parse(age1);
                }
            });
            break;
        case 4:
            Console.WriteLine("enter id");
            var id2 = Console.ReadLine();
            userList.RemoveAll(x => x.Id == int.Parse(id2));
            break;
        case 5:
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(JsonSerializer.Serialize(userList));
            streamWriter.Close();
            break;
    }
    
    
}


    
