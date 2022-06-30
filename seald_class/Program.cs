using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seald_class
{
    sealed class student
    {
        public void Getstudent()
        {
            Console.WriteLine("this my seald class");

        }

        class collage   //: student                       //shild class can  not be inheritance to  other class
        {
            public void getcollage()
            {
                Console.WriteLine("this is my get collage methoad ");

            }
        }

    }
    public  class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.Getstudent();
            Console.ReadLine();
        }
    }
}
