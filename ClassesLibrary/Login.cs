using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //fields

        private string _username;
        private string _password;

        //properties

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //constructors

        public Login (string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Login()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format(
                "Username = {0}\n" +
                "Password = {1}\n",
                Username, Password);
        }

    }//end class
}
