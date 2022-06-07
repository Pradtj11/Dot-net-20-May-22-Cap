using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
        
    /*Create a new C # project with three classes plus another class to test the logic in your code. The main classes 
     * of the program are the following classes:

    Person
    Student
    Teacher
    The Student and Teacher classes inherit from the Person class.
    The Student class will include a public Study() method that will write I'm studying on the screen.
    The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.
    The Teacher class will include a public Explain() method that will write I'm explaining on the screen.
    Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.
    You must create another test class called StudentProfessorTest with a Main method to do the following:
    Create a new Person and make him say hello
    Create a new Student, set an age, say hello, and display her age on the screen.
    Create a new Teacher, set an age, say hello and start the explanation.*/

        class Person
        {
             protected int age;
            public void Greet(string name)
            {
                Console.WriteLine("Hello " +name);
            }
            public void SetAge(int _age)
            {
                age = _age;
            
            }
        }
        class Student:Person
        {
            public void study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                  
                Console.WriteLine("My age is: "+age +" years old on the screen");
            }
        }
        class Teacher:Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm Explaining on the screen");
            }
        }
    class StudentProfessorTest
    {
        public static void Main17(string[] args)
        {
            Student s = new Student();
            s.Greet("Pragati");
            s.SetAge(20);
            s.study();
            s.ShowAge();
            Teacher t = new Teacher();
            t.Greet("Priya");
            t.SetAge(25);
            t.Explain();
        
        }

    }
}
