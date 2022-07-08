using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Or_Function
{
    class Program
    {
        public void Show()
        {
            Console.WriteLine("Welcome Nilesh");
            Console.WriteLine("Hello nilesh");

        }  
        public static void Show1()
        {
            Console.WriteLine("Welcome to c#");
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of number {0} " + result); 
            return result;  


        }

        static void Main(string[] args)
        {
           // Program.Show1(); 
            Program program = new Program();
            program.Add(50,50); 
           // program.Show();
            Console.ReadLine();  


        }
    }
}
