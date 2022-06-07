using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    //Write a program in C# Sharp to print all unique elements in an array.

    class Class8
    {
        static void Main8(string[] args)
        {
            int[] arr = new int[5] { 20, 40, 40, 50, 20 };
            int counter = 0;
            
                    for (int i = 0; i < arr.Length; i++)
                    {
                        counter = 0;
                        for (int j = 0; j < i-1; j++)
                        {   
                            //increment the counter when search value is duplicate
                            if (arr[i] == arr[j])
                            {
                                counter++;
                            }

                        }

                        for (int k = i+1; k < arr.Length; k++)
                        {
                            if (arr[i] == arr[k])
                            {
                                counter++;
                            }
                            if (arr[i] == arr[i + 1])
                            {
                                i++;
                            }
                        }
                        if (counter == 0)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        
                    }
            Console.ReadLine();
                  }
            }
        }
    

