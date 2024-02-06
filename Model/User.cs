using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Model
{
    internal class User
    {
        private int userId;
        private string username;
        private string password;
        private string role;
        public User()
        {
            

        }
        //Parameterized constructor
        public User(int userId, string username, string password, string role)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.role= role;

        }
        //getter and setter methods
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string  Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
