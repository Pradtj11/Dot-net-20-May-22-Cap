using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //WAP to find factorial of a number
    class Class10
    {
        static void Main10(string[] args)
        {
            int n, res;
            Console.Write("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            res=factorial(n); //calling function
            Console.WriteLine("Factorial of " + n + " is " + res);

        }
        static int factorial(int n) //function declaration
        {
            int res;
            if(n==0)
            {
                res = 1;
            }
            else
            {
                res = n * factorial(n - 1);
            }
            return res;
        }
    }
}
