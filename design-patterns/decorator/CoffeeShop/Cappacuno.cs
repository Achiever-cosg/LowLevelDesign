namespace CoffeeShop
{
    public class Cappacuno : ICoffee
    {
        private double price = 100.00;
        private string description = "Capacuno";

        public string GetDescription()
        {
            return this.description;
        }

        public double GetCost()
        {
            return this.price;
        }
    }
}