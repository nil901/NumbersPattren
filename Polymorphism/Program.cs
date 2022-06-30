using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
  public class Program
    {

        public void add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);


        }


        public int add(int a, int b)
        {

            int c = a + b;
            ///Console.WriteLine(c);

            return c;

        }

        public void add(string a, string b)
        {

            string c = a + " " + b;
            Console.WriteLine(c);

        }
        public void add(float a, float b)
        {

            float c = a + b;
            Console.WriteLine(c);

        }

        class animal
        {
            public void Eat()
            {
                Console.WriteLine(" dog it  food");
            }

        }


        class Dog : animal
        {
            public void Eat()
            {
                Console.WriteLine("peee peee peee");
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Dog d = new Dog();
            Dog p = new Dog();


            // obj.add(); 
            // obj.add(2.5f,1.5f);
            obj.add("Nilesh", "pathak");
            Console.ReadLine();
        }
    }
}
