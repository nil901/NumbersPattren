//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Open_closed_principle
//{
//    public interface IShape
//    {
//        //This interface represent Open Modification /Extension 

//        public double Area();
//    }

//    public class CalculateArea
//    {
//        public double CalculateArea(IShape shape)
//        { 
//           // close for modification
//            return shape.Area;
//        }
//    } 

//        public class Circle : IShape
//        {
//            const double PI = 3.14;

//            double radius;

//            public Circle(double radius)
//            {
//                this.radius = radius;
//            }
//        public double Area => 2 * PI * radius;

//    }

//        public class Rectangle : IShape
//        {
//            double length;

//            double width;


//            public Rectangle(double length, double width)
//            {
//                this.length = length;
//                this.width = width;
//            }


   

//        double IShape.Area()
//        {
//            return length * width;
//        }
//    }
//    class OpenClosePrincipal : IShape
//    {
//        CalculateArea calculate = new CalculateArea();
//        Circle circle = new Circle(3);

//        Rectangle rectangle = new Rectangle(5,6);

//        public double Area()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    }

