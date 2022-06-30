using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{

    class Example<T>  // this is a placholader <T>
    {
        T box;

        public Example(T b)
        {
            this.box = b;
        }

        public T getBox()
        {
            return this.box;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Example<int> E = new Example<int>(20);
            Example<string> name = new Example<string>("Nilesh");
            Example<char> e3 = new Example<char>('A');
            Console.WriteLine(E.getBox());
            Console.WriteLine(name.getBox());
            Console.WriteLine(e3.getBox());
            Console.ReadLine();
        }
    }
}
