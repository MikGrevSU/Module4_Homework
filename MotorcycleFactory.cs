namespace TransportSystem
{
    class MotorcycleFactory : VehicleFactory
    {
        private readonly string _type;
        private readonly int _engine;

        public MotorcycleFactory(string type, int engine)
        {
            _type = type;
            _engine = engine;
        }

        public override IVehicle CreateVehicle()
        {
            return new Motorcycle(_type, _engine);
        }
    }
}
