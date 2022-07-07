using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Un_Boxing
{
   public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10; // value type
            object obj1 = num1; // implicit conversion from value type to reference type Boxing 
            int num2 = (int)obj1; // Un-Boxing

        }
    }
}
