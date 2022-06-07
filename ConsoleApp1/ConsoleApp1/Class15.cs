using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Constructor & destructor
    class Emp
    {
        private string EmpName;
        private int EmpId;
        private string EmpGen;
        private int EmpSal;
        private string CompanyName;


    public Emp()
    {
        CompanyName = "Capgemini";
    }

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
            Console.WriteLine("Company name is: "+CompanyName);
        }

        //Destructor
        ~Emp()
    {

    }

        class Class15
        {
            static void Main15(string[] args)
            {
                Emp[] arr = new Emp[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    Emp e = new Emp();
                    e.getdata();
                    arr[i] = e;
                }

                for (int i=0; i<arr.Length; i++)
                {
                    arr[i].printData();

                }

            }
        }
    }
}
