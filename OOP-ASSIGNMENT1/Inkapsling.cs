using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT1
{
    class User
    {
        public string Username { get; private set; }  
        private string password;                        

        public User(string username) //sätter username
        {
            Username = username;
        }

        public void SetPassword(string pwd)//sätter password
        {
            password = pwd;
        }

        public bool VerifyPassword(string input)//kollar om password är samma som console inputen.
        {
            return password == input;
        }
    }
}
