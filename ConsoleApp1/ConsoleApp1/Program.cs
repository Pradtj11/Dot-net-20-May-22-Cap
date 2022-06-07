using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main8(string[] args)
        {
            //Console.WriteLine("Pragati!");


         //WAP to find the no is evan or odd

            //int a=10;
            //if(a%2==0)
            //{
            //  Console.WriteLine("Given number is Even");
            //}
            //else
            //{
            //  Console.WriteLine("Given number is not a even number");
            //}
            //Console.ReadLine();


            /*check wheather a person is able to vote or not.
            and if age is greater than 60 enter he is a senior citizen.*/

            //int age = 50;
            //if(age<18)
            //{
            //  Console.WriteLine("You are not able to vote");
            //}
            //else if(age>=18)
            //{
            //  Console.WriteLine("You are able to vote");
            //}
            //else if(age>60)
            //{
            //  Console.WriteLine("Yor are a senior citizen");
            //}
            //else
            //{
            //  Console.WriteLine("Invalid Age");
            //}




            // WAP to print week days by using switch statement
            //int choice = 4;

            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
              case 1:
                Console.WriteLine("Monday");
              break;
            case 2:
              Console.WriteLine("Tuesday");
            break;
            case 3:
              Console.WriteLine("Wednesday");
            break;
            case 4:
              Console.WriteLine("Thusday");
            break;
            case 5:
              Console.WriteLine("Friday");
            break;
            case 6:
              Console.WriteLine("Saturday");
            break;
            case 7:
              Console.WriteLine("Sunday");
            break;

            default:
              Console.WriteLine("Invalid Choice");
            break;
            }


            /* Create a calculator
             where you will ask user what he want to do
             1.Add
             2.Sub
             3.Division
             4.Multiplication

             1
             Please enter 2 values
             4,5
             Sum of two number is 9
             5
             Enter a valid choice*/

            // Console.WriteLine("1.Addition\n 2.Substraction\n 3.Division\n 4.Multiplication");
            //Console.Write("Enter your choice : ");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter 2 values : ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //  int s2 = Convert.ToInt32(Console.ReadLine());
            //int result;
            // switch(choice)
            //{
            //  case 1:
            //    result = s1 + s2;
            //  Console.WriteLine("Addition is : " + result);
            //break;

            // case 2:
            //   result = s1 - s2;
            // Console.WriteLine("Substraction is : " + result);
            //break;

            //  case 3:
            //    result = s1 / s2;
            //  Console.WriteLine("Division is : " + result);
            // break;

            //  case 4:
            //    result = s1 * s2;
            //   Console.WriteLine("Multiplication is : " + result);
            //  break;

            // default:
            //   Console.WriteLine("Invalid choice.....Please enter valid choice");
            //  break;
            //}



        }
    }
}
