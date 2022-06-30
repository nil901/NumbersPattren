using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IEmployee
    {
        void Show();


    }
    class PartTimeEmployee : IEmployee 
    {
        public void Show()
        {
            Console.WriteLine("This is a methoad of I Employee interface");
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee employee = new PartTimeEmployee();
            employee.Show();
            Console.ReadLine();
        }
    }
}
