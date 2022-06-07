using System;


namespace ConsoleApp1
{

    //Create a program to multiply 2 matrix
    class Class5
    {
        static void Main5(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            for (int row=0; row<2; row++)
            {
                for(int col=0; col<2; col++)
                {
                    Console.WriteLine("Please enter the value for arr1[" + row + "," + col + "]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row=0; row<2;row++)
            {
                for(int col=0; col<2; col++)
                {
                    Console.WriteLine("Please enter the value of arr2[" + row + "," + col + "]: ");
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row=0; row<2; row++)
            {
                for(int col=0; col<2; col++)
                {
                    arr3[row, col] = 0;
                    for(int i=0; i<2; i++)
                    {
                        arr3[row, col] += arr1[row, i] * arr2[i, col];
                    }
                }
               
            }
            for(int row=0; row<2; row++)
            {
                for(int col=0; col<2; col++)
                {
                    Console.Write(arr3[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 
        }
    }
}
