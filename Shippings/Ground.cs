
namespace Demo.Services
{
    public class Ground : Shipping
    {

        public double GetCost(Order order)
        {
            if (order.GetTotal() > 100)
            {
                return 0;
            }

            return Math.Max(10, order.GetTotalWeight()*1.5);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(5);
        }
    }
}