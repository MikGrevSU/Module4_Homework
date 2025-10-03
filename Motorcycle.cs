using System;

namespace TransportSystem
{
    class Motorcycle : IVehicle
    {
        public string Type { get; }
        public int EngineCapacity { get; }

        public Motorcycle(string type, int engineCapacity)
        {
            Type = type;
            EngineCapacity = engineCapacity;
        }

        public void Drive()
        {
            Console.WriteLine($"{Type} мотоцикл едет. Объем двигателя: {EngineCapacity} куб.см");
        }

        public void Refuel()
        {
            Console.WriteLine($"{Type} мотоцикл заправляется бензином.");
        }
    }
}
