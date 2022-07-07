using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table__Collection
{
    class Program
    { 

        static void Main(string[] args)
        {
            //Hashtable hash = new Hashtable();
            ////hash.Add("Id" ,1144 );
            ////hash.Add("Name", "Nilesh");
            ////hash.Add("salary", 10000.00);
            ////hash.Add("IsMarried",false);

            

            Hashtable hash = new Hashtable()
            {
                {"Id" ,23 } ,
                {"Name","Nilesh" },
                {"Salary",10000.00  },
                {"Age",25} ,
                {"IsMarried",false } 
            };

            Console.WriteLine(hash["Age" ] );
            Console.ReadLine(); 


        }
    }
}
