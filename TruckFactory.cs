namespace TransportSystem
{
    class TruckFactory : VehicleFactory
    {
        private readonly double _capacity;
        private readonly int _axles;

        public TruckFactory(double capacity, int axles)
        {
            _capacity = capacity;
            _axles = axles;
        }

        public override IVehicle CreateVehicle()
        {
            return new Truck(_capacity, _axles);
        }
    }
}
