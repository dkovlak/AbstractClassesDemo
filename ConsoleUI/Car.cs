using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk {get; set;}

        public Car()
        {
            HasTrunk = true;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is being driven.");
        }
    }
}

