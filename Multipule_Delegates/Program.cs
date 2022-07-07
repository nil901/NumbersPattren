using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipule_Delegates
{
    public  delegate void Calculation (int a, int b); 
    
    public delegate void ShowMassage();

    public delegate void Calculation2(int num);
    class Program
    {
        public static void Addition(int num1)
        {
            int b =  num1 * num1;
            Console.WriteLine("Substarction",b);

        }

        public static void Show()
        {
            Console.WriteLine("This is show methold");

        } 

        public static void  Addition(int a, int b) 

        {
            int c = a + b;
            Console.WriteLine("Addition result:{0}",c);  

        } 
      
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(Addition);
            cal.Invoke(50, 40);

            //Calculation2 cal2 = new Calculation2(Addition);
            ////cal2.Invoke(20); 
            //cal2(100);
            Console.ReadLine();
            //ShowMassage msg = new ShowMassage(Show);
            //msg.Invoke();  




        }
    }
}
