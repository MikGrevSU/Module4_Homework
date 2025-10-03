namespace TransportSystem
{
    class BusFactory : VehicleFactory
    {
        private readonly int _seats;
        private readonly string _category;

        public BusFactory(int seats, string category)
        {
            _seats = seats;
            _category = category;
        }

        public override IVehicle CreateVehicle()
        {
            return new Bus(_seats, _category);
        }
    }
}
