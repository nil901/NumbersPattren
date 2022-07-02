using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_principle
{
    public class Shape
    {
        string shape;
        const double PI = 3.14; 

        public Shape(string shape)
        {
            this.shape = shape; 
        }
        public double Area()
        {
            double area = 0;

            if (this.shape.ToLower().Contains("circle"))
            {
                Console.WriteLine("Enter the radius ");
                string radius = Console.ReadLine();
                area = 2 * PI * Convert.ToInt64(radius);
            } else if (this.shape.ToLower().Contains("rectangle")) {
                Console.WriteLine("Enter the Length ");
                string Length = Console.ReadLine();
                Console.WriteLine("Enter the Width ");
                string Width = Console.ReadLine();
                area = Convert.ToInt64(Length) * Convert.ToInt64(Width);

            }
            return area;
        }

    } 
   public class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape("rectangle");
            //Console.WriteLine("Area Circle of" + shape.Area());

            Shape shape = new Shape("circle");
            Console.WriteLine("Area Circle of" + shape.Area());
            Console.ReadLine();
        }
    }
}
