﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.WriteLine("Exception has occured because of 0");
        }
    }
    public class Class34
    {

        public double DivisionOperator(double n, double d)
        {
            if (d == 0)
                throw new DivByZero();

            return n / d;
        }

        public static void Main34()
        {
            Class12 o = new Class12();
            try
            {
                o.DivisionOperator(9, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
