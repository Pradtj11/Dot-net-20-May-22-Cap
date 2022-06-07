using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*Create a C# program that implements an abstract class Animal that has a Name property of type text 
     * and three methods SetName (string name), GetName and Eat. The Eat method will be an abstract method of type void. 
     * You will also need to create a Dog class that implements the above Animal class and the Eat method that says the dog is Eating. 
     * To test the program ask the user for a dog name and create a new Dog type object from the Main of the program, 
     * give the Dog object a name, and then execute the GetName and Eat methods.*/
    public abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
        
    }
    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    class Class22
    {
        static void Main22(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
