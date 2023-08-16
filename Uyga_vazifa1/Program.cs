//Console.WriteLine("ismingizni kiriting: ");
//string ism = Console.ReadLine();
//Console.WriteLine("sharifingizni kiriting: ");
//string sharif = Console.ReadLine();
//Console.WriteLine(ism);
//Console.WriteLine(sharif);

//Console.WriteLine("I\nLove\nC#");
//string file = "D:\\Games\\Sifu by Igruha";
//Console.WriteLine($"Sifu by Igruha fayl joylangan {file}");
//Console.WriteLine("text kiriting: ");
//string soz = Console.ReadLine();
//Console.WriteLine($"{soz.Length} sozning uzunligi {soz[0]}");
//Console.WriteLine("text indexni kiriting: ");
//int index1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("text uzunligini kiriting: ");
//int uzun =  Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{soz.Substring(index1, uzun)}");
//using System;
//namespace passwordgenerator
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Harflar qatnashsinmi: (yes/no)");
//            string soz = Console.ReadLine();
//            Console.WriteLine("sonlar qatnashsinmi: (yes/no)");
//            string son = Console.ReadLine();
//            Console.WriteLine("simvollar qatnashsinmi: (yes/no)");
//            string simvol = Console.ReadLine();
//            Console.WriteLine("Password uzunligini kiriting: ");
//            int uzunlik = Convert.ToInt32(Console.ReadLine());
//            string password = GeneratePassword(uzunlik, soz, simvol, son);
//            Console.WriteLine("Generatsiyalangan parol: " + password);
//        }
//        static string GeneratePassword(int uzunlik, string soz, string son, string simvol)
//        {
//            const string harflar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//            const string simvollar = "!@#$%^&*()_+";
//            const string numbers = "0123456789";
//            string belgilar = "";
//            if (soz.ToLower() == "yes") 
//                belgilar += soz;
//            if (simvollar.ToLower() == "yes")
//                belgilar += simvollar;
//            if (numbers.ToLower() == "yes")
//                belgilar += numbers;
//            Random random = new Random();
//            string password = "";
//            while(password.Length < uzunlik)
//            {
//                password += belgilar[random.Next(belgilar.Length)];
//            }
//            return password;

//        }
//    }
//}
/*Console.WriteLine("emailingizni kiriting: ");
var gmail = Console.ReadLine();
var change = string.Empty;
var count = (int)default;
var count1 = (int)default;
foreach (var i in gmail)
{
    var ite = Convert.ToInt32(i);
    if ((ite >= 97 && ite <= 122)||(ite >= 65 && ite <= 90)||(ite >= 48 && ite <= 57)||  ite == 46 || ite == 64)
    {
        count++;
    }
    else
    {
        Console.WriteLine($"kodingizni shu yerida hato bor {i}");
    }
    if (ite >= 65 && ite <= 90)
    {
        change += Convert.ToChar(ite + 32);
        count1++;
        
    }
    else
    {
        change += item;
    }
    if (count == gmail.Length && count1 != 0) ;
    Console.WriteLine($"manabu yaxshi variant{change}");
}*/
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
        Console.WriteLine($"1 - Add Project\n2 - Add Task\n3 - Add Admin\n4 - Add Developer\n5 - See Developer list\n6 - Assign Task to a Developer\n7 - Send Notification to Developer\n8 - See tasks list with Assigned Users / and not assigned tasks\n10 - Change Password");
        var res = Console.ReadLine();
    menu:
        switch (res)
        {
            case "1":
                Console.WriteLine("1 - Add Project\n2 - See Projects");
                while (true)
                {
                    var ress = Console.ReadLine();

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
                            goto menu;
                    }
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

internal interface IUser
{
    void Add(User user);
    User AuthenticateUser(string login, string password, User user);
}
public enum UserRole
{
    ProjectManager,
    Developer
}
internal class User : IUser
{
    /* private static User _defaultAdmin;
     public static User GetDefaultAdmin()
     {
         if (_defaultAdmin == null)
             _defaultAdmin = new User();
         return _defaultAdmin;
     }*/
    public User(byte roleID, string username, string password, string emailAddres)
    {
        Username = username;
        Password = password;
        Email = emailAddres;
        RoleId = roleID;
    }
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Login { get; set; }
    public byte RoleId { get; set; }
    public string Password { get; set; }


    public string Email { get; set; }

    public readonly List<Project> AssignedProjects;
    public readonly List<string> Comments;

    public void Add(User user)
    {
        Add(user);
    }

    public User AuthenticateUser(string login, string password, User user)
    {
        return null;
    }
}
internal class Project
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public readonly List<Task> Tasks;
    public void AddTasks(Task tasks)
    {

    }

}
internal class ProjectManager : User
{
    public ProjectManager(string username, string password, string emailAddres) : base((int)UserRole.ProjectManager, username, password, emailAddres)
    {
    }
}
internal class Notification
{
    public User Recipient { get; set; }
    public string Message { get; set; }
    public DateTime Timsestamp { get; set; }
}
internal class Developer : User
{
    public Developer(string username, string password, string emailAddres) : base((int)UserRole.ProjectManager, username, password, emailAddres)
    {

    }
}
internal class TaskManagerSystem
{
    private List<User> users;
    private List<Project> projects = new List<Project>();

    public static int AuthnticateUser(string login, string password, User user)
    {
        if (user.Username == login && user.Password == password)
            return user.RoleId;
        else return 1;
    }

    public void AddUser(User user)
    {
        AddUser(user);
    }

    public void CreateProject(string projectName, string description)
    {
        if (!string.IsNullOrEmpty(projectName) && projectName.Length < 3)
        {
            projects.Add(new Project() { Title = projectName, Description = description });
            Console.WriteLine("Correct!!");
        }
    }

    public void DisplayProjectlists()
    {
        foreach (Project project in projects)
        {
            if (project == null)
            {
                throw new Exception("hechnima yuq");
            }
        }
    }

    public void AddTaskToProject()
    {

    }




}

