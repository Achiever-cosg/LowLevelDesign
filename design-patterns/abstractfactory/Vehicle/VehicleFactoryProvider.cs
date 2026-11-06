namespace AbstractFactory.Vehicle
{
    public class VehicleFactoryProvider
    {
        public static IVehicleFactory GetFactory(bool isRich)
        {
            if (isRich)
            {
                return new LuxuryFactory();
            }
            else
            {
                return new NonLuxuriousFactory();
            }
        }
    }
}
