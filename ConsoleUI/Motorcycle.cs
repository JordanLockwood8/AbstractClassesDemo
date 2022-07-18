using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSaddleBags { get; set; }
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle drive Virtual");
        }
    }
}
