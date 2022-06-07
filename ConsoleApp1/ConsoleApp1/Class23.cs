using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{ 
    class HMV

    {
        public string DriveHMV()
    {
        return null;
    }
        private int _numberofWheels;
        public HMV(int numberofWheels)
        {
           numberofWheels = _numberofWheels;
            Console.WriteLine(numberofWheels+" wheelers driving");
        }
    }
    class TwoWheeler
    {
        public string DriveTwoWheeler()
        {
            string Result1= "2 wheelers driving";
            return Result1;
        }
    }
    class Driving:TwoWheeler
    {
        public string Drive()
        {
            
            return DriveTwoWheeler();
        }
        public string Drive(int numberofWheels)
        { 

            string obj = Convert.ToString(new HMV(4));
            return obj;
        }

    }
    class Class23
    {
        static void Main23(string[] args)
        {
            var driving = new Driving();
            var drive = driving.Drive();
            Console.WriteLine($"{drive}");
            var drive1 = driving.Drive(4);
            Console.WriteLine($"{drive1}");
        }   
    }
}
