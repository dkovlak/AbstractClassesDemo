using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        /*
         * Create an abstract class called Vehicle
         * The vehicle class shall have three string properties Year, Make, and Model
         * Set the defaults to something generic in the Vehicle class
         * Vehicle shall have an abstract method called DriveAbstract with no implementation
         * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
         */
        public string Year { get; set; }
        public string Make { get; set; } = "BMW";
        public string Model { get; set; }

        public Vehicle()
        {
            Year = "Unknown";
            Make = "Unknown";
            Model = "Unknown";
        }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Virtual driving");
        }
    }
}

