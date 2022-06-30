using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Derived_and_Base_Class_
{

    class VisitingEmployee : Employee
    {
        public int visitingSalary;
        public int vistingHours;


    }
    class permanentemployee : Employee
    {
        public int permanenteSalary;
        public int PermanenteHours;

    }
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public int Age;
        public long EmployeeContactNumber;

        public void show()
        {
            Console.WriteLine("this is methoad of base class");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            VisitingEmployee vi = new VisitingEmployee();
            vi.show();
            vi.EmployeeId = 12;
            permanentemployee prm = new permanentemployee();
            prm.EmployeeId = 15;

            Console.WriteLine(vi.EmployeeId);
            Console.WriteLine(prm.EmployeeId);
            Console.ReadLine();
        }
    }
}
