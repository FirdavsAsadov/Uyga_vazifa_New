//1-TODO modulidan foydalanamiz 
using System.Runtime.InteropServices;
///2-TodoLIst servisi yaratamiz va undan foydalanamiz 
///3-TODOLIST servisida DIsplay hamma vazifalarni ekranga chiqarish
///4-Mark Done bitta vazifani bajarilgan deb belgilash
///5-Add vazifa qo'shish
/// <summary>
/// 2-TodoLIst servisi yaratamiz va undan foydalanamiz 
/// </summary>
/// 
ToDoList toDoList = new ToDoList();
while (true)
{
    Console.WriteLine("Choose a command  \ndisplay all - d\nmark done - m\nadd - a\nexit - e or E ");
    var chose = Console.ReadLine();
    switch (chose)
    {
        case "d" or "D":
            {
                toDoList.display();
            }
            
            break;
        case "m" or "M":
            {
                Console.WriteLine("choose which task: ");
                toDoList.display();
                var index = int.Parse(Console.ReadLine()) - 1;
                toDoList.MarkDone(index);
            }
            break;
        case "a" or "A":
            {
                Console.WriteLine("Enter the Task name: ");
                var itemname = Console.ReadLine();


                toDoList.Add(itemname);

            }
            break;
        case "e" or "E":
            break;
        default: { Console.WriteLine("Invalid Commmand"); break; }
    }
}


public class ToDo
{
    public string taskname { get; set; }
    public bool isdone { get; set; }

}

public class ToDoList
{
    public List<ToDo> Task1 = new List<ToDo>();

    public void display()
    {
        Console.WriteLine("TodoList: ");
        for(var i = 0; i< Task1.Count; i++)
        {
            Console.WriteLine($"{i + 1} {Task1[i].taskname} - {(Task1[i].isdone ? "Done" : "Not Done")}");
        }
    }
    public void MarkDone(int index)
    {
        if(index >= 0 && index < Task1.Count)
        {
            Task1[index].isdone = true;
            Console.WriteLine($"{Task1[index].taskname} Marked as done");
        }
        else
        {
            Console.WriteLine("invalid index");
        }
    }

    public void Add(string tasknaMe)
    {
        ToDo task = new ToDo {taskname = tasknaMe, isdone = false};
        Task1.Add(task);
        Console.WriteLine($"Task \"{tasknaMe}\" added");
    }
}
