using System;

namespace TransportSystem
{
    class Bus : IVehicle
    {
        public int Seats { get; }
        public string Category { get; }

        public Bus(int seats, string category)
        {
            Seats = seats;
            Category = category;
        }

        public void Drive()
        {
            Console.WriteLine($"Автобус ({Category}) перевозит пассажиров, мест: {Seats}.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Автобус ({Category}) заправляется дизельным топливом.");
        }
    }
}
