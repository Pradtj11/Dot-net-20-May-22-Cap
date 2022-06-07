using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Rectangle
    {
        protected double side1();
        protected double side2();
    }

    interface Circle
    {
        protected double radius();
    }

    class Shape : Rectangle, Circle
    {
        public string ToString()
        {
            return null;
        }
        
        public double side1(double x)
        {
            return x;
        }

        public double side2(double y)
        {
            return y;
        }
        int x, y;
        public double Perimeter()
        {
            return 0.00;
        }

        public double radius(double Radius)
        {
            return Radius;
        }
            public double Area()
        {
            return 0.00;
        }

        double Rectangle.side1()
        {
            throw new NotImplementedException();
        }

        double Rectangle.side2()
        {
            throw new NotImplementedException();
        }

        double Circle.radius()
        {
            throw new NotImplementedException();
        }
    }
    class Class28
    {
        static void Main28(string[] args)
        {

        }
    }
}
