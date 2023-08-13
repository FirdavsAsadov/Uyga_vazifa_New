using N21_CT_task1.Modul;
using System.ComponentModel.Design;
while (true)
{
    var _instance = new TaskManagerSystem();
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
                Console.WriteLine("1 - Add Project\n2 - See Projects");
                var ress = Console.ReadLine();
                menu1:
                switch (ress)
                {
                    case "1":
                        Console.WriteLine("Proyekt Nomini kiriting: ");
                        string projectName = Console.ReadLine();
                        Console.WriteLine("Proyektga Ta'rif bering: ");
                        string descriptions = Console.ReadLine();
                        _instance.CreateProject(projectName, descriptions);
                        break;
                    case "2":
                        _instance.DisplayProjectlists();
                        break;
                    case "0":
                        goto menu1;
                }
                break;
            
            
          


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
    break;
}


