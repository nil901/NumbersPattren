using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    partial class student
    {
        public void getstudent()
        {
            Console.WriteLine("this my partial class");

        }
    }

    partial class student
    {
        public void studentRecoards()
        {
            Console.WriteLine("this my partial class");

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.getstudent();

            Console.ReadLine(); 

        }
    }
}
