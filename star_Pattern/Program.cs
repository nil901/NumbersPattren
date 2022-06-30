using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_Pattern
{
  public class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i<=5; i++ )   // 5 row created
            //{
            //    for (int j = 1; j<=5; j++) // nested loop
            //    {
            //        Console.Write(" *" );
            //    }  
            //   Console.WriteLine();
            //}   
            //Console.ReadLine();  


            //for (int i = 1; i <= 5; i++) // 5 row created
            //{
            //    for (int j = 1; j <= i; j++) // nested loop
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine(); 

            //for (int i = 1; i <= 5; i++) // 5 row created
            //{
            //    for (int j = i; j <= 5; j++) // nested loop
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            for (int i = 1; i <= 5; i++)   // 5 row created
            {
                for (int j = 1; j <= i; j++) // nested loop
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 4; i++)   // 5 row created
            {
                for (int j = i; j <= 4; j++) // nested loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
