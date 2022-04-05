using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    interface IAccount
    {
        public bool PasswordChecker(string Password);
        void Showinfo();
       
    }
}
