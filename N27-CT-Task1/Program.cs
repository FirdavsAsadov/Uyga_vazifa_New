using System.ComponentModel.Design;
using System.Text.Json;
using System.Text.Json.Serialization;
using N27_CT_Task1;
using Task = N27_CT_Task1;

public class Program
{
    static void Main(string[] args)
    {
        TaskService service = new TaskService();
        List<Tasks> tasks = new List<Tasks>();
        const string pattern = @"D:\person\Tasks.txt";
        //var jsonFile = File.ReadAllText(pattern);
        //var result = JsonSerializer.Deserialize<List<TaskService>>(jsonFile);
        var priority = Priority.Low;
        Tasks newTask = new Tasks(1, "Do laundry", priority, false, new DateTime(2023, 8, 20));
        Tasks newTask1 = new Tasks(2, "Doental", Priority.High, false, new DateTime(2023, 8, 21));
        Tasks newTask2 = new Tasks(3, "Walk the dog", Priority.Medium, false, new DateTime(2023, 8, 22));
        tasks.Add(newTask);
        tasks.Add(newTask1);
        tasks.Add(newTask2);
        var jsonData = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(pattern, jsonData);
        var jsonFile = File.ReadAllText(pattern);
        var result = JsonSerializer.Deserialize<List<TaskService>>(jsonFile);
        Console.WriteLine($"1 - Add\n2 - CompleteTasks\n3 - GetTasks\n4 - Write");
        menu:
        while (true)
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Id: ");
                    var taskId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Task Description: ");
                    var taskDescription = Console.ReadLine();
                    Console.WriteLine("Enter Task Priority\n 1 - Low\n2 - High\n3 - Medium: ");
                    var taskPriority = int.Parse(Console.ReadLine());
                    switch (taskPriority)
                    {
                        case 1:
                            priority = Priority.Low;
                            break;
                        case 2:
                            priority = Priority.High;
                            break;
                        case 3:
                            priority = Priority.Medium;
                            break;
                        default:
                            break;
                        
                    }
                    Console.WriteLine("Enter Task Due Date: ");
                    var date = Console.ReadLine();
                    var dates = DateTime.Parse(date);
                    break;
                case 2:
                    StreamWriter writer = new StreamWriter(pattern);
                    writer.Write(JsonSerializer.Serialize(tasks));
                    writer.Close();
                break;
                case 3:
                    goto menu;
                    
                
            }
            
        }

    }


}