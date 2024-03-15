namespace Demo.Services
{
    public interface Shipping
    {
        double GetCost(Order order);
        DateTimeOffset GetDate();
    }
}