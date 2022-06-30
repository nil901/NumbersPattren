using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__class
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int productPrice;


        static Product()
        {

            ProductId = 111;
            ProductName = "Mobile";
            productPrice = 5454;
        }

        public static void getProductDetails()
        {
            Console.WriteLine("Product  Id =  {0}", ProductId);
            Console.WriteLine("Product  Name = {0}", ProductName);
            Console.WriteLine("product Price = {0}", productPrice);


        }

        public static void GetDiscount()
        {

            int d_Discount = productPrice / 10;
            Console.WriteLine("You= dicound amount is {0} : ", d_Discount);
            Console.WriteLine("Total cost of product is :{0}", (productPrice - d_Discount));

        }

    }
    //public class Iteams : Product {

    // } 
    public class Program
    {
        static void Main(string[] args)
        {

            Product.getProductDetails();
            Product.GetDiscount();                              // This is correct way create a Object  class name define a object 
            Console.ReadLine();

        }
    }
}
