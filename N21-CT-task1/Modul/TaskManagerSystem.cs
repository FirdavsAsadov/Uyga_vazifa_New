using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    internal class TaskManagerSystem
    {
        private List<User> users;
        private List<Project> projects = new List<Project>();
        private List<Developer> developersList = new List<Developer>();
        List<string> errors = new List<string>();

        public static int AuthnticateUser(string login,  string password, User user)
        {
            if (user.Username == login && user.Password == password)
                return user.RoleId;
            else return 1;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void CreateProject(string projectName, string description)
        {
            if (!string.IsNullOrEmpty(projectName) && projectName.Length >= 3)
            {
                projects.Add(new Project() { Title = projectName, Description = description });
                Console.WriteLine("Correct!!");
            }
        }

        public void DisplayProjectlists()
        {
            foreach(var project in projects)
            {
                if (project != null)
                {
                    Console.WriteLine(project.ToString());
                }
                else
                    Console.WriteLine("yuq");
            }
            
        }

        public void AddDeveloper(Developer developer)
        {
            const string pattern = "^[a-zA-Z'-]+$";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrWhiteSpace(developer.Username) && !regex.IsMatch(pattern))
            {
                Console.WriteLine("Name Is not Valid!!");
                errors.Add(developer.Username);
            }
            else
            {
                developersList.Add(developer);
            }
            const string patternEmail = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            if(string.IsNullOrEmpty(developer.Email) && !regex.IsMatch(patternEmail))
            {
                Console.WriteLine("Email is not Valid!!");
                errors.Add(developer.Email);
            }
            else
            {
                developersList.Add(developer);
            }
            if (string.IsNullOrWhiteSpace(developer.Password) && developer.Password.Length < 3)
            {
                Console.WriteLine("Developer Password Is not Valid!!");
                errors.Add(developer.Password);
            }
            else
            {
                developersList.Add(developer);
            }
             
            /*developersList.Add(developer);
            Console.WriteLine("Correct!!");*/
        }

        public void DisplaydeveloperList()
        {
            foreach(var developers in developersList)
            {
                if(developers != null)
                {
                    Console.WriteLine(developers.ToString());
                }
                else
                Console.WriteLine("Developer listida hech kim yo'q!!");
            }
        }




    }

}
