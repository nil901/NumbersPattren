using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInCSharp
{
public class Program
    {
        enum Level
        {
            low,
            Medium,
            High

        }
        static void Main(string[] args)
        {
            Level myVar = Level.High;
            Console.WriteLine(myVar);
            Console.ReadLine();

        }
    }
}
