using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Cast_Delegates
{
    public delegate void Calculation(int num1, int num2);
   public class Program
    { 
        public static void addition( int num1 , int num2)
        {
            int Result = num1 + num2;
            Console.WriteLine("Addition result is:{0} " , Result); 

        } 
        static void Main(string[] args)
        {
           // Program.addition(12, 13);
             Calculation cal = new Calculation(addition);
             cal.Invoke(12,50); 
             Console.ReadLine(); 
        }
    }
}
