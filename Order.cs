using System.Collections;
using Demo.Models;
using Demo.Services;

namespace Demo
{
    public class Order
    {
        private IList<Product> lineItems;
        private Shipping shipping;
        public Order(IList<Product> products)
        {
            lineItems = products;
        }
        public int GetTotal() => lineItems.Count;
        public double GetTotalWeight() => lineItems.Sum(x => x.Weight);
        public void SetShippingType(Shipping shippingType) => 
            shipping = shippingType;
        
        public double GetShippingCost()
        {
            return shipping.GetCost(this);
        }
        public DateTime GetShippingDate() => DateTime.Now;
    }
}