using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		
		}
        public override void DriveAbstract()
        {
            Console.WriteLine(GetType().Name);
        }

		public bool HasTrunk { get; set; }

		
		
	}
}

