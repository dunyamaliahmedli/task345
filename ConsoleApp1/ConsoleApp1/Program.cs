using System;
using ConsoleApp1.Models;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User();
            ////Student student1 = new Student("Dunyamali Ehmedli", 132);
            //student1.Password = "Asal12";
            //student1.PasswordChecker(student1.Password);
            ////user1.Showinfo();


            //student1.Showinfo();
            Student student = new Student("Dunyamali Ehmedli",52);
            student.Password = "salam123";
            student.PasswordChecker(student.Password);
            student.Showinfo();

            Student student3 = new Student("Dunyamali Ehmedli", 55);
            student3.Password = "salam123";
            student3.PasswordChecker(student3.Password);
            student3.Showinfo();

        }

        
    }
}
