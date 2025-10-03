using System;

namespace TransportSystem
{
    class Car : IVehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public string FuelType { get; }

        public Car(string brand, string model, string fuelType)
        {
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} едет по дороге.");
        }

        public void Refuel()
        {
            Console.WriteLine($"{Brand} {Model} заправляется топливом: {FuelType}.");
        }
    }
}
