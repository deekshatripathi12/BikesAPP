using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    public class Login
    {
        private string userName;
        private string userPassword;

        //declare properties operations
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string UserPassword
        {
            get { return this.userPassword; }
            set { this.userPassword = value; }
        }
        public Login()
        {
            this.UserName = "Undefined";
            this.UserPassword = "Undefined";
        }
        public Login(string userName, string userPassword)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
        }
        public override string ToString()
        {
            return this.UserName + ", " + this.UserPassword;
        }
    }
}
