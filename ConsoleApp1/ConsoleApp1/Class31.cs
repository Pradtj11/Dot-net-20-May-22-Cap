using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//non grneric collection
namespace ConsoleApp1
{

    class Class31
    {
        private static object l;

        static void Main31(string[] args)

        {

            //********HashTable********
            //collection of key and values
                Hashtable ht = new Hashtable();
                ht.Add("ora", "oracle");
                ht.Add("py", "Python");
                ht.Add("vb", "vb.net");
                ht.Add("cs", "cs.net");

            //DictionaryEntry is a class whose object represents the data in combination of key and value
                foreach(DictionaryEntry item in ht)
                {
                Console.WriteLine(item.Key+"==========>" +item.Value);
                }
                Console.WriteLine("====================");


            //********sortedlist
            //it is a class that has the combination of arraylist and hashtable
 
                SortedList sl = new SortedList();
                sl.Add("ora", "oracle");
                sl.Add("vb", "vb.Net");
                sl.Add("cs", "cs.net");
                sl.Add("asp", "asp.net");

                foreach (DictionaryEntry item in sl)
                {
                    Console.WriteLine(item.Key + "===>" + item.Value);
                }
            Console.WriteLine("====================");

            //************stack************
            //************LIFO*************
            Stack stk = new Stack();
            stk.Push("oracle");
            stk.Push("Python");
            stk.Push("Java");
            stk.Push(".Net");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================");

            //*************Queue************
            //*************FIFO*************

            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("Asp.net");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================");
        }

    }
}