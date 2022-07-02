using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     public delegate void calculation(int a ,int b);
  
    public  class Program
    { 
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is {0}" , result); 
        }
        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("subtraction result is {0}", result);
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication result is {0}", result);
        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("division result is {0}", result);
        }
       
        static void Main(string[] args)
        {
            calculation obj = new calculation(Program.Addition);
            calculation obj1 = new calculation(Program.multiplication);
            obj1(5, 6); 
            
            //obj.Invoke(20,20);
            //obj = multiplication;
            //obj(20,50);         // point dffrent function 
            //obj = division;
            //obj(7 , 5);
          Console.ReadLine();  
                

        }
    }
}
