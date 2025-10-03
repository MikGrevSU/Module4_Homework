using System;

namespace TransportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите транспорт (car, motorcycle, truck, bus):");
            string type = Console.ReadLine()?.ToLower();

            VehicleFactory factory = type switch
            {
                "car" => CreateCarFactory(),
                "motorcycle" => CreateMotorcycleFactory(),
                "truck" => CreateTruckFactory(),
                "bus" => CreateBusFactory(),
                _ => null
            };

            if (factory == null)
            {
                Console.WriteLine("Неизвестный тип транспорта.");
                return;
            }

            IVehicle vehicle = factory.CreateVehicle();
            vehicle.Refuel();
            vehicle.Drive();
        }

        private static CarFactory CreateCarFactory()
        {
            Console.Write("Введите марку: ");
            string brand = Console.ReadLine();

            Console.Write("Введите модель: ");
            string model = Console.ReadLine();

            Console.Write("Введите тип топлива: ");
            string fuel = Console.ReadLine();

            return new CarFactory(brand, model, fuel);
        }

        private static MotorcycleFactory CreateMotorcycleFactory()
        {
            Console.Write("Введите тип мотоцикла (спортивный/туристический): ");
            string type = Console.ReadLine();

            Console.Write("Введите объем двигателя (куб.см): ");
            int engine = int.Parse(Console.ReadLine());

            return new MotorcycleFactory(type, engine);
        }

        private static TruckFactory CreateTruckFactory()
        {
            Console.Write("Введите грузоподъемность (тонн): ");
            double capacity = double.Parse(Console.ReadLine());

            Console.Write("Введите количество осей: ");
            int axles = int.Parse(Console.ReadLine());

            return new TruckFactory(capacity, axles);
        }

        private static BusFactory CreateBusFactory()
        {
            Console.Write("Введите количество мест: ");
            int seats = int.Parse(Console.ReadLine());

            Console.Write("Введите тип автобуса (городской/междугородний): ");
            string category = Console.ReadLine();

            return new BusFactory(seats, category);
        }
    }
}
