using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string writeText ="hello Nilesh";
            //File.WriteAllText("F:\\FileText.txt  ", writeText);

            string readText = File.ReadAllText("F:\\FileText.txt");
            Console.WriteLine(readText);
            Console.ReadLine(); 



        }
    }
}
