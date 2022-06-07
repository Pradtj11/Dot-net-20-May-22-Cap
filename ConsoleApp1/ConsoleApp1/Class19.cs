using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum
    {

        //Method Overloading
        public void sum(int a)
        {
            int b = a;
            Console.WriteLine(b);
        }
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void sum(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }
        public void sum(string a, string b)
        {
            int d = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(d);
        }
    }

    class Class19
    {
        public static void Main19(string[] args)
        {
            Sum s = new Sum();
            s.sum(20);
            s.sum(20, 10);
            s.sum(10, 20, 30);
            s.sum("10", "20");
        }
    }  
    
}
