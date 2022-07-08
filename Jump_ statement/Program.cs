using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump__statement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {

                //if( i == 0)
                //{
                //    //break; b     //break statment

                //}  

                //if(i % 2 == 1) {

                //    continue;     // continue statment 

           // }
                if (i== 5) {
                    goto stop;
                  }
                

               Console.WriteLine(i);
            }
            

            Console.WriteLine("Loop Terminate ");

            stop:
            Console.WriteLine("Program exit");
            Console.ReadLine();
        }
    }
}
