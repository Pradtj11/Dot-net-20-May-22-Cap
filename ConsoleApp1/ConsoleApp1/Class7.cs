using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main7(string[] args)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 5; col < row; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
