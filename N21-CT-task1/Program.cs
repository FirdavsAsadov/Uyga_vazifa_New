using N21_CT_task1.Modul;
using System.ComponentModel.Design;

User user = new ProjectManager("admin", "admin", "admin@gmail.com");
User user2 = new Developer("firdavs", "firdavs2006", "toshmurodovj13@gmail.com");
Console.WriteLine("Login kiriting: ");
string login = Console.ReadLine();
Console.WriteLine("Password Kiriting: ");
string password = Console.ReadLine();

int result = TaskManagerSystem.AuthnticateUser(login, password, user);
if (result == (int)UserRole.ProjectManager)
{   
    Console.WriteLine($"1 - Add Project\n2 - Add Task\n3 - Add Admin\n4 - Add Developer\n5 - See Developer list\n6 - Assign Task to a Developer\n7 - Send Notification to Developer\n8 - See Project List\n9 - See tasks list with Assigned Users / and not assigned tasks\n10 - Change Password");
    var res = Console.ReadLine();
    menu:
    switch (res)
    {
        case "1":
            Console.WriteLine("add project");
            break;
        case "2":

            break; 
        case "3":

            break;
        case "4":

            break;
        case "5":

            break;
        case "6":

            break;
        case "7":

            break;
        case "8":

            break;
        case "9":

            break;
        case "10":

            break;
        case "0":
            Console.Clear();
            goto menu;
                

    }
    
}

if (result == (int)UserRole.Developer)
{
    Console.WriteLine($"1 - See notifications\n2 - See Tasks\n3 - Mark Task done\n4 - Change Password");
    var results = Console.ReadLine();
    switch (results)
    {
        case "1":

            break;
    }
}


