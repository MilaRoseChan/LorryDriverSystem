using System;
namespace DriverDepot
{
    public class Driver
    { 
        protected string username;
        protected string password;


        public Driver(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

       public bool CheckPassword(string checkPassword)
        {
            if (password == checkPassword)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}