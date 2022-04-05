using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student: User
    {
        private int _id=0;
        public int ID { get;}
        public string Fullname { get; set; }
        public int Point { get; set; }


        public Student()
        {
            ++_id;
            ID = _id;
        }
     
        public Student(string fullname,int point)
        {
            this.Fullname = fullname;
            this.Point = point;
            //++_ID;
            //_ID = ID;

        }
        public void Showinfo()
        {

            Console.WriteLine($"id: {ID}  fULLname:{Fullname}   Point:{Point}");

        }



    }
}
