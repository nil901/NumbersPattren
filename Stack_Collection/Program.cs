using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>(); //stores elements in LIFO style
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);

            //foreach (var item in mystack) {
            //    Console.WriteLine(item + "  ");

            //}




            // create a Stack from an array, 

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6,7, 8, 9 };
            //Stack<int> ST = new Stack<int>(arr);

            //foreach (var item in ST)
            //{
            //    Console.WriteLine(item + "" );
            //} 


           


        }
    }
}
