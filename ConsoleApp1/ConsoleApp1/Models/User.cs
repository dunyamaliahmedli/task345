using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class User: IAccount

    {
        private int ID = 0; 
        public int _ID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            ++ID;
            _ID = ID;

        }
       

       

        public void Showinfo()
        {
            
            Console.WriteLine($"id: {_ID}  fULLname:{Fullname}   email:{Email}");
            
        }

        public bool PasswordChecker(string Password)
        {
            this.Password = Password;
            bool isupper = false;
            bool isdigit = false;
            bool islower = false;
               
            if (Password.Length >= 8 && Password!=null && Password!=string.Empty)
            {
                foreach (var item in Password)
                {
                    if (char.IsUpper(item))
                    {
                        isupper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        islower = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        isdigit = true;
                    }

                    if (isupper && islower  && isdigit)
                        {
                        return false;
                                        
                        }
                }
             
            }return true;
            
        }

        
    }
}
