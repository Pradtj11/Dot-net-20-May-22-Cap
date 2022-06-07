using System;
using System.Collections.Generic;
using System.Text;

/*Create a C# program that implements an IVehiculo interface with two methods, one for Drive of type void and another for Refuel of type bool that has a parameter of type integer 
with the amount of gasoline to refuel. Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel 
methods of the car.The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. The Refuel method will increase the gasoline of the car 
and return true.To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, 
finally execute the 
Drive method of the car*/

namespace ConsoleApp1
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car : IVehicle
    {
        
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public int Fuel;
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Car is Driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel = Fuel + amount;
            return true;
        }
    }
    class Class27
    {
        static void Main27(string[] args)
        {
            Car c = new Car(0);
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (c.Refuel(fuel))
            {
                c.Drive();
            }
        }
    }
}
