using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        //public static void Main6(string[] args)
        //{
        /* print  *
                  * *
                  * * *
                  * * * *
                  * * * * *
         */

        //for (int i = 1; i <= 5; i++)
        //{
        //  for (int j = 1; j <= i; j++)
        //{
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();

        //}
        //Console.ReadLine();



        /* print  * * * * * * * *
                  * *         * *
                  *   *     *   *
                  *     *  *    *
                  *       *     *
                  *     *  *    *
                  *   *      *  *
                  *  *        * *
                  * * * * * * * *           
         */
        static void Main1(string[] args)
        {
            for (int row = 0; row<= 9; row++)
            {
                for (int col = 0; col<= 9; col++)
                {
                    if (row == 0 || col == 0 || row == 9 || col == 9 || row == col || col==9 -row+ 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}

