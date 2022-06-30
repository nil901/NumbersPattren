using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumber
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a any number");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"this {n} Number  is even");
            }
            else
            {
                Console.WriteLine($"this {n} Number is odd ");
            }
            Console.ReadLine();

        }
    }
}
