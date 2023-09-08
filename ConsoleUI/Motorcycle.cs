using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public bool HasSideCart { get; set; }

		public Motorcycle()
		{
			HasSideCart = true;
		}

        public override void DriveAbstract()
        {
			Console.WriteLine("This motorcycle is being driven");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle is driving in virtual");
        }
    }
}

