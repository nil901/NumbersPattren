using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Program
    {
        public class Calculator
        {
            int num1;
            int num2;
            int result;

            public void Add()
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }

            public void subtraction()
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }

            static void Main(string[] args)
            {
                Calculator cal = new Calculator();

                cal.num1 = 50;
                cal.num2 = 60;
                cal.Add();
                cal.subtraction();

                Console.ReadLine(); 



            }
        }
    }
}