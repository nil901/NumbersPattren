using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public abstract class parson
    {


        public string FirstName;
        public string lastName;
        public int age;
        public long MobileNumber;

        public abstract void PrintDetails();


    }
    class student : parson
    {
        public int RollNuber;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.lastName;

            Console.WriteLine("Student name is ,{0}", name);
            Console.WriteLine("student  age, {0}", age);
            Console.WriteLine("Student MobileNumber", MobileNumber);
            Console.WriteLine("student roll Number,{0}", RollNuber);
            Console.WriteLine("student fees,{0}", Fees);


        }


    }

    class Techer : parson
    {
        public string Qulification;
        public int salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.lastName;

            Console.WriteLine("Student name is ,{0}", name);
            Console.WriteLine("student  age, {0}", age);
            Console.WriteLine("Student MobileNumber", MobileNumber);

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            student Nilesh = new student();
            Nilesh.FirstName = "Nilesh";
            Nilesh.lastName = "Pathak";
            Nilesh.age = 25;
            Nilesh.MobileNumber = 9834705267;
            Nilesh.RollNuber = 42;
            Nilesh.Fees = 30000;
            Nilesh.PrintDetails();

            Console.ReadLine();
        }
    }
}
