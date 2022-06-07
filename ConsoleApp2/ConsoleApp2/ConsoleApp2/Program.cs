using ConsoleApp2.Models;
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
         //for insersion
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            SampleDBContext db = new SampleDBContext();
            Tblsample tblsample = new Tblsample();
            tblsample.Test = "Pragati Tanpure";

            db.Tblsamples.Add(tblsample);
            db.SaveChanges();
            Console.WriteLine("Hello World!");

            //How we can show the values
            var data = db.Tblsamples;

            Console.WriteLine("Values from database ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Test);
            }

            // How we can delete the value
            Console.WriteLine("Pleae enter id of your name which you want to delete");
            int DeleteItem = Convert.ToInt32(Console.ReadLine());
            var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
            db.Tblsamples.Remove(DeleteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Test);
            }

        //How we can Update the value

            Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Test = newName;
            db.Tblsamples.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Test);
            }
        }
}
}
