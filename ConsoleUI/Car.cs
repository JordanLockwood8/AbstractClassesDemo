using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        public int NumOfWindows { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("this car is in drive");
        }
    }
}
