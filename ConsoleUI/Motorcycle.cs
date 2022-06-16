using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine(GetType().Name);
        }
        public override void DriveVirtiual()
        {
            Console.WriteLine(GetType().Name, GetType().BaseType.Name);

        }


        public bool HasTrunk { get; set; }
        public bool HasSideCart { get; set; }
    }

}