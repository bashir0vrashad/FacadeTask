using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTask
{
    internal class FuelInjectionSystem
    {
        public void InjectFuel()
        {
            Console.WriteLine("Fuel injected into the engine");
            Console.WriteLine();
        }

        public void StopFuelInjection()
        {
            Console.WriteLine("Fuel injection stopped");
            Console.WriteLine();
        }
    }
}
