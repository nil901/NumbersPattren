using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class Program
    {

        //public static int Add(int a , int b)
        //{
        //   int  sum = a + b;
        //    return sum; 


        //}   

        public static int add(params int[] nums)
        {
            int sum = 0;
            foreach (var i in  nums )
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args){

            Console.WriteLine(Program.add(10,10,10,10,10,10,10,10,10,10,10,10));    
            Console.ReadLine(); 
            
        } 

    }
}
