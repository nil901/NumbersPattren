using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPattren
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(i); 

            //    }
            //    Console.WriteLine();  
            //} 
            //Console.ReadLine();

            int count = 0;
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 1; j <= i; j++)
                { 
                    count++;
                    Console.Write(count);

                }
                Console.WriteLine();
                
            }
            Console.WriteLine("hello world");
            Console.ReadLine();

        }
    }
}
