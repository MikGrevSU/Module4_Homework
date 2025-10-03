using System;

namespace TransportSystem
{
    class Truck : IVehicle
    {
        public double Capacity { get; }
        public int Axles { get; }

        public Truck(double capacity, int axles)
        {
            Capacity = capacity;
            Axles = axles;
        }

        public void Drive()
        {
            Console.WriteLine($"Грузовик везет {Capacity} тонн груза, количество осей: {Axles}.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Грузовик заправляется дизельным топливом.");
        }
    }
}
