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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car()
            {
                Year = 1995,
                Make = "jeep",
                Model = "cherokee",
                HasTrunk = true,
                NumOfWindows = 4
            };
            Motorcycle cycle1 = new Motorcycle()
            {
                Year = 1985,
                Make = "Harley",
                Model = "lll",
                HasSideCar = true,
                HasSaddleBags = true,
            };
           
            Vehicle vehicle1 = new Car()
            {
                Year = 2000,
                Make = "VW",
                Model = "bus",
                HasTrunk = false,
                NumOfWindows = 6
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Year = 1999,
                Make = "Indian",
                Model = "jjj",
                HasSaddleBags = false,
                HasSideCar = true
            };
            //*Add the 4 vehicles to the list
            vehicles.Add(car1);
            vehicles.Add(cycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            //*Using a foreach loop iterate over each of the properties
            foreach (var item in vehicles)
            {                
                Console.WriteLine($"Year:{item.Year}");
                Console.WriteLine($"Make:{item.Make}");
                Console.WriteLine($"Model:{item.Model}");
                Console.WriteLine("");
            }
            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine("");
            cycle1.DriveAbstract();
            cycle1.DriveVirtual();
            #endregion
            Console.ReadLine();
        }
    }
}
