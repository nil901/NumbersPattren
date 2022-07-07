using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue__Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> que = new Queue<int>();    //stores the elements in FIFO style
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            que.Contains(4);

            foreach(var id in que){
                Console.WriteLine(id);
            }

     



            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("N");
            strQ.Enqueue("I");
            strQ.Enqueue("L");
            strQ.Enqueue("E");
            strQ.Enqueue("S");
            strQ.Enqueue("H");

            Console.WriteLine("Total elements: {0}", strQ.Count); 

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); 

            Console.WriteLine("Total elements: {0}", strQ.Count);

            Console.ReadLine();

        }
    }
}
