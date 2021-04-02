using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new List<Vehicle>();
            Car tradesman = new Car()
            {
                HasTrunk = false,
                Year = "1978",
                Make = "Dodge",
                Model = "Tradesman"
            };
            Motorcycle fxr = new Motorcycle()
            {
                HasSidecar = false,
                Year = "1990",
                Make = "Harley",
                Model = "Fxr"
            };
            Vehicle sportster = new Motorcycle()
            {
                HasSidecar = false,
                Year = "1994",
                Make = "Harley",
                Model = "Sportster"
            };
            Vehicle nova = new Car()
            {
                HasTrunk = true,
                Year = "1971",
                Make = "Chevy",
                Model = "Nova"
            };
            vehicle.Add(nova);
            vehicle.Add(sportster);
            vehicle.Add(fxr);
            vehicle.Add(tradesman);

            foreach (var item in vehicle)
            {
                Console.WriteLine($"Year: {item.Year} \n" +
                    $"Make: {item.Make} \n" +
                    $"Model: {item.Model}");
                item.DriveVirtual();
                Console.WriteLine();
            }
            
            


            #region Vehicles

            /*
             *done- Create an abstract class called Vehicle
             *done- The vehicle class shall have three string properties Year, Make, and Model
             * done-Set the defaults to something generic in the Vehicle class
             * done-Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done-Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * done-Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * done-Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * done-Provide the implementations for the abstract methods
             * done-Only in the Motorcycle class will you override the virtual drive method
            */

            // done-Create a list of Vehicle called vehicles
            
            /*
             * done-Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * done- new it up as one of each derived class
             * done-Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
