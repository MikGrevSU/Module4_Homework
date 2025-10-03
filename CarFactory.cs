namespace TransportSystem
{
    class CarFactory : VehicleFactory
    {
        private readonly string _brand;
        private readonly string _model;
        private readonly string _fuel;

        public CarFactory(string brand, string model, string fuel)
        {
            _brand = brand;
            _model = model;
            _fuel = fuel;
        }

        public override IVehicle CreateVehicle()
        {
            return new Car(_brand, _model, _fuel);
        }
    }
}
