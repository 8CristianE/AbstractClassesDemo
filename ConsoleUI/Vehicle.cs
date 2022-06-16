using System;
namespace ConsoleUI
{
    public abstract class Vehicle
	{
		public string Year { get; set; } = "2000";
		public string Make { get; set; } = "make";
		public string Model { get; set; } = "model";
        
		public abstract void DriveAbstract();
   
 
		public virtual void DriveVirtiual()
        {
			Console.WriteLine(GetType().Name);
        }
	
	}
}

