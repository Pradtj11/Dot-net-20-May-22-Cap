using ConsoleApp3.Models;
using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            SampleDB1Context db = new SampleDB1Context();
            EmployeeDetail empdetail = new EmployeeDetail();

            bool Exit = false;
            while (true)
            {
                Console.WriteLine("Please enter your choice :\n 1.Add Record\n 2.List Record\n 3.Update Record\n 4.Delete Record\n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                
            switch (choice)
                {
                    //for Add records
                    case 1:
                        Console.WriteLine("Please enter Employee first name: ");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Please enter Employee first name: ");
                        string lname = Console.ReadLine();
                        Console.WriteLine("Please enter Employee salary amount: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        empdetail.Fname = fname;
                        empdetail.Lname = lname;
                        empdetail.Salary = salary;
                        db.EmployeeDetails.Add(empdetail);
                        db.SaveChanges();
                        break;

                    case 2:
                        var data = db.EmployeeDetails;

                        Console.WriteLine("Values from database ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Fname + " | " + item.Lname + " | " + item.Salary);
                            
                        }
                        break;

                    case 3:
                        var data1 = db.EmployeeDetails;
                        Console.WriteLine("Pleae enter id which you want to update");
                        int InsertItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new fname");
                        var newFname = Console.ReadLine();
                        var UpdateObject = db.EmployeeDetails.Where(x => x.Id == InsertItem).FirstOrDefault();
                        UpdateObject.Fname = newFname;
                        db.EmployeeDetails.Update(UpdateObject);

                        Console.WriteLine("Please enter the new lname");
                        var newLname = Console.ReadLine();
                        var UpdateObject1 = db.EmployeeDetails.Where(y => y.Id == InsertItem).FirstOrDefault();
                        UpdateObject1.Fname = newLname;
                        db.EmployeeDetails.Update(UpdateObject1);

                        Console.WriteLine("Please enter the Updated Salary");
                        var newSalary = Console.ReadLine();
                        var UpdateObject2 = db.EmployeeDetails.Where(z => z.Id == InsertItem).FirstOrDefault();
                        UpdateObject2.Fname = newSalary;
                        db.EmployeeDetails.Update(UpdateObject2);
                        db.SaveChanges();

                        foreach (var item in data1)
                        {
                            Console.WriteLine(item.Id + " | " + item.Fname + " | " + item.Lname + " | " + item.Salary);
                        }
                        break;

                    case 4:
                        var data2 = db.EmployeeDetails;
                        Console.WriteLine("Pleae enter id of your name which you want to delete");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = db.EmployeeDetails.Where(x => x.Id == DeleteItem).FirstOrDefault();
                        db.EmployeeDetails.Remove(DeleteObject);
                        db.SaveChanges();

                        foreach (var item in data2)
                        {
                            Console.WriteLine(item.Id + " | " + item.Fname);
                        }
                        break;

                    case 5:
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("Please enter correct choice!!");
                        break;
                }
                if (Exit)
                    break;
            }

                        
        }


          
    }
}