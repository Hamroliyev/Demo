namespace Demo.Services
{
    public class Sea : Shipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotal() < 100)
            {
                Console.WriteLine("Sea");
            }

            return Math.Max(15, order.GetTotalWeight()*2);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(6);
        }
    }
}