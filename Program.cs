using Demo.Services;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
             Sea sea = new Sea();
             Ground ground = new Ground();
            Air air = new Air();
            order.SetShippingType(ground);
            Console.WriteLine(order.GetShippingCost());

            order.SetShippingType(sea);
            Console.WriteLine(order.GetShippingCost());

            order.SetShippingType(air);
            order.SetShippingType(air);
            Console.WriteLine(order.GetShippingCost());

        }
    }
}
