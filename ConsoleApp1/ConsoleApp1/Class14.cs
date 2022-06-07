using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Methods & stroring data by using Array
    
        class Employee
        {
            public string EmpName;
            public int EmpId;
            public string EmpGen;
            public int EmpSal;

        //Methods for taking data from user
        public void getdata()
        {
            Console.WriteLine("Enter Employee Details: ");
            Console.WriteLine("Enter Employee Name : ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Id :");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender :");
            EmpGen = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            EmpSal = Convert.ToInt32(Console.ReadLine());
        }

        //Method for printing data
        public void printData()
        {
            Console.WriteLine("Name is: " + EmpName);
            Console.WriteLine("Id is: " + EmpId);
            Console.WriteLine("Gender is: " + EmpGen);
            Console.WriteLine("Salary is: " + EmpSal);
        }
        }

    class Class14
    {

        static void Main14(string[] args)
        {
            //calling methods

            //Employee e = new Employee();
            //e.getdata();
            //e.printData();


            //storing data by using array
            Employee[] arr = new Employee[3];
            for(int i=0; i<arr.Length; i++)
            {
                Employee e = new Employee();
                e.getdata();
                arr[i] = e;
            }

            for(int i=0; i<arr.Length; i++)
            {
                arr[i].printData();
            }
        }
    }
}
