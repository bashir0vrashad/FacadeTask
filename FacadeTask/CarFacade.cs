using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTask
{
    internal class CarFacade
    {
        private Engine engine;
        private IgnitionSystem ignitionSystem;
        private FuelInjectionSystem fuelInjectionSystem;

        public CarFacade()
        {
            engine = new Engine();
            ignitionSystem = new IgnitionSystem();
            fuelInjectionSystem = new FuelInjectionSystem();
        }

        public void StartCar()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the car");
            Console.WriteLine();
            ignitionSystem.TurnOn();        
            fuelInjectionSystem.InjectFuel();         
            engine.Start();
            Console.WriteLine("Car started");
            Console.WriteLine();
        }

    
        public void StopCar()
        {
            Console.WriteLine();
            Console.WriteLine("Stopping the car");
            Console.WriteLine();
            engine.Stop();          
            fuelInjectionSystem.StopFuelInjection();       
            ignitionSystem.TurnOff();
            Console.WriteLine("Car stopped");
            Console.WriteLine();
        }
    }
}
