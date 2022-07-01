using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIFFERENCE__BETWEEN_NON_GENERIC_AND_GENERIC_COLLECTIONS
{
    public class Program
    {
        static void Main(string[] args)
        {  
            //GenericUriParser Type
           // Array  
            int[] arr = new int[3];
            arr[0] = 11; 
            arr[1] = 12; 
            arr[2] = 13;

            List<int> Mynumber = new List<int>();
            Mynumber.Add(12);
            Mynumber.Add(45);
            Console.WriteLine(Mynumber.Capacity);
            Mynumber.Add(51);
            Mynumber.Add(71);
            Console.WriteLine(Mynumber.Capacity);
            // Mynumber.Add("nilesh")  // Not Allowd this string data type


            // Non-Generic collections 
            //ArrayList arrayList = new ArrayList();
            // arrayList.Add("Nilesh");
            // arrayList.Add(56);
            // arrayList.Add(12.2);
            // Console.WriteLine(arrayList.Capacity);
            // arrayList.Add('a');
            // arrayList.Add(true);
            // Console.WriteLine(arrayList.Capacity);


            Console.ReadLine();


        }
    }
}
