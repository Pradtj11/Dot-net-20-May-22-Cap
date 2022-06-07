using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    //transpose of a matrix

    class Class6
    {
        static void Main6(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];

        //input for arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter value for arr1["+row+","+col+"]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //input for arr2
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter value for arr2[" + row + "," + col + "]: ");
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr1[row, col] + "\t");
                }
            }
            Console.WriteLine("Matrix after transpose");

            //Output
            for(int row=0; row<2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr2[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
