using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//non generic collection
//ArrayList 

namespace ConsoleApp1
{
    class Class30
    {
        static void Main30(string[] args)
        {
            ArrayList al = new ArrayList();
            string str ="Pragati";
            int x = 7;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
