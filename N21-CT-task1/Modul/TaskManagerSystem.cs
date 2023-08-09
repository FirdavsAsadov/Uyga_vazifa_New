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

        public void AddUser()
        {

        }

        public void CreateProject()
        {

        }

        public void AddTaskToProject()
        {

        }




    }

}
