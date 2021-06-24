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
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car focus = new Car() { HasTrunk = true, Name = "focus", Make = "Ford", Model = "Focus", Year = 2013 };
            Motorcycle harley = new Motorcycle() { HasSideCar = true, Name = "harley", Make = "Harley Davidson", Model = "Chopper", Year = 1978 };

            Vehicle sedan = new Car() { HasTrunk = true, Name = "sedan", Make = "Dodge", Model = "Charger", Year = 2018 };
            Vehicle prius = new Car() { HasTrunk = true, Name = "prius", Make = "Toyota", Model = "Prius", Year = 2015 };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(harley);
            vehicles.Add(focus);
            vehicles.Add(sedan);
            vehicles.Add(prius);

            foreach (var item in vehicles)
			{
                Console.WriteLine($"Name {item.Name}, Make {item.Make}, Model {item.Model}, Year {item.Year}");
                item.DriveAbstract();
                Console.WriteLine("");

			}


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            //Console.ReadLine();
        }
    }
}
