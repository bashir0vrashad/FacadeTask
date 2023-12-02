using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTask
{
    internal class IgnitionSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Ignition system turned on");
            Console.WriteLine();
        }

        public void TurnOff()
        {
            Console.WriteLine("Ignition system turned off");
            Console.WriteLine();    
        }
    }
}
