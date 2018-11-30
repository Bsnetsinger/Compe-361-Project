using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoPage
{
    class Admin : Person, IComparable<Admin>
    {
        private LinkedList<User> userList;

        public Admin() : base()
        {
            userList = new LinkedList<User>();
        }

        public Admin(string firstName, string lastName, string username, string password, int age, char sex)
            : base(firstName, lastName, username, password, age, sex)
        {
            userList = new LinkedList<User>();
        }

        public int CompareTo(Admin obj)
        {
            if (obj == null)
                return 1;

            return this.getUsername().CompareTo(obj.getUsername());
        }

        public void setList(LinkedList<User> list) { this.userList = list; }

        public bool banUser(string username)
        {
            if (!userList.Contains(new User("", "", username,"",0,'m')))
                return false;

            userList.Remove(new User("", "", username, "", 0, 'm'));
            return true;
        }

        public bool deleteUser(string username)
        {

        }

        //public User serchUser(string username)
        //{
        //    if (!userList.Contains(new User("", "", username, "", 0, 'm')))
        //        return null;
            
        //}
}
