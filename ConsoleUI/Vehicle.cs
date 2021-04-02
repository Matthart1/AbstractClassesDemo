using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1985";
        public string Make { get; set; } = "Pontiac";
        public string Model { get; set; } = "Firebird";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually n drive.");
        }

    }
}
