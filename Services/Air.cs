
namespace Demo.Services
{
    public class Air : Shipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotal() < 100)
            {
                return 0;
            }

            return Math.Max(20, order.GetTotalWeight()*3);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(7);
        }
    }
}