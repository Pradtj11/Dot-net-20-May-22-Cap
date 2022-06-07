using System;
using System.Collections.Generic;
using System.Text;


//Exceptin handling
//try catch finally

namespace ConsoleApp1
{
    class Class33
    {
            public static void Main33()
            {
                try
                {
                    int a = 5, b = 0;
                    // int c = a / b;
                    int[] ar = new int[5];
                    //ar[5] = 9;
                    //Console.WriteLine(c);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Index out---Some error occured");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Some error occured");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

                finally
                {
                    Console.WriteLine("I am coming from finally");
                }
            }
        }
    }


