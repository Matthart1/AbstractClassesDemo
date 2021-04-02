using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasSidecar { get; set; } = false;
 
        public override void DriveAbstract()
        {
            Console.WriteLine("This bike is in gear.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("She's running");
        }
    }
}
