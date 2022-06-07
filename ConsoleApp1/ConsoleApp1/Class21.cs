using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
//Method overriding
//virtual keyword
    
    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("I'm in BaseClass");
        }
    }
    class DerivedClass: BaseClass
    {
        public override void show()
        {
            Console.WriteLine("I'm in DerivedClass");
        }
    }
    class Class21
    {
      public static void Main21(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.show();

            BaseClass obj;
            obj = new BaseClass();
            obj.show();

            obj= new DerivedClass();
            obj.show();
        }
    }
}
