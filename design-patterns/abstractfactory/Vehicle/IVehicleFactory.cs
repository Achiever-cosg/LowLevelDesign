namespace AbstractFactory.Vehicle
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string carType);
    }
}
