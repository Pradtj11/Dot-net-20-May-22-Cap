using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*
      * private constructor
      * default constructor
      * Parameterzied Constructor
      * Copy Constructor
      * static Constructor
      */

    class Sampleclass
    {
        private int a;
        private int b;

        //default constructor
        public Sampleclass()
        {
            Console.WriteLine("Hi I'm default constractor...");
        }

        //parameterized constructor
        public Sampleclass(int _a)
        {
            int a = _a;
        }

        //Copy constroctor
        /*A Constructor that create an object by coping variables from another object or that copies that data
        from one object into another object*/

        public Sampleclass(Sampleclass c)
        {
            a = c.a;
            b = c.b;
        }
        public void SetValue(int _a)
        {
            a = _a;
        }
        public void printValue()
        {
            Console.WriteLine(a);
        }
    }
    class Class16
    {
        public static void Mian16(string[] args)
        {
            Sampleclass S = new Sampleclass();
            S.SetValue(1);
            Sampleclass S1 = new Sampleclass(S);
            S1.printValue();
        }
        
    }
}
