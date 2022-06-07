using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class13
    {
        static void Main13(string[] args)
        {
            //var vs dynamic variable

            //var keyword this will be used for declaring a variable and this will be a compile time variable
            //dynamic keyword will be a runtime variable (typecasting done internally)

            var x = 1;
            //x = "Vikash"; //shows an error because data type of x is changing.

            var y= "Pragati";
            //y = 1;
            dynamic x1 = "Pragati"; //automatically doing implicit & explicit typecasting
            x1 = 2; //answer will be 2-(internal typecasting of string to int done in dynamic keyword)

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x1);
        }
    }
}
