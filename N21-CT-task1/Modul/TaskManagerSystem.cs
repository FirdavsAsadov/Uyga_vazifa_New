using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    internal class TaskManagerSystem
    {
        private List<User> users;
        private List<Project> projects;

        public static int AuthnticateUser(string login,  string password, User user)
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
            if (!string.IsNullOrWhiteSpace(projectName) && projectName.Length < 3)
            {
                projects.Add(new Project() { Title = projectName, Description = description, Id = Guid.NewGuid() });
                Console.WriteLine("Correct!!");
            }
        }

        public void DisplayProjectlists()
        {
            foreach(var project in projects)
            {
                if(project == null)
                {
                    Console.WriteLine("Prpjectda hech nim yo'q!!");
                }
            }
        }

        public void AddTaskToProject()
        {

        }




    }

}
