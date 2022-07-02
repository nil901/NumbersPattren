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
              // include the System.IO namespace

            //string writeText = "Hello World!";  // Create a text string
            //File.WriteAllText("F:\\FileText.txt  ", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("F:\\FileText.txt");  // Read the contents of the file
            Console.WriteLine(readText);
            Console.ReadLine();// Output the content
        }
    }
}
