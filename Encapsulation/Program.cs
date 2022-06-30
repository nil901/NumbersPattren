using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Account
    {
        int AccountBalance = 1000;

        //public void SetBalance(int amount)
        //{
        //    if (amount < 0)
        //    {
        //        Console.WriteLine("you can not type negitive value");
        //    }
        //    else
        //    {
        //        AccountBalance = amount;

        //    }

        //}
        //public void getBalacnce()
        //{
        //      Console.WriteLine ("This is youar account balance :" +  AccountBalance); 
        //} 

        public int balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("You can not pass value nagetive");
                }
                else
                {
                    AccountBalance = value;
                }

            }

            get
            {
                return AccountBalance;
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            //ac.SetBalance(-1000);  
            //ac.getBalacnce();  
            ac.balance = -23;
            Console.WriteLine("Youar Account balance is + " + ac.balance);
            Console.ReadLine();
        }
    }
}
