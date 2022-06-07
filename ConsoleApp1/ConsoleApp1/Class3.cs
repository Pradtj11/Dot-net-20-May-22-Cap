using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        //find the second highest number of an array
        static void Main3(string[] args)
        {
            int max1, max2;
            int[] arr = { 12, 82, 54, 23, 85, 13, 57, 32, 44 };
            Console.WriteLine("Array elements are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            max1 = arr[0];
            max2 = arr[1];
            for(int i=0; i < arr.Length; i++)
            {
                if(arr[i]>max1)
                {
                    
                    max1 = arr[i];
                    max2 = max1;
                }
                else if(arr[i]>max2)
                {
                    max2 = arr[i];
                }
                Console.WriteLine();
                Console.WriteLine("Second highest number is : " + max2);
                Console.ReadLine();
            }
        }
    }

}
