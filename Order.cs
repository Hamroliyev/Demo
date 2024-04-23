using System.Collections;
using Demo.Models;
using Demo.Services;

namespace Demo
{
    public class Order
    {
        private IList<Product> lineItems;
        private Shipping shipping;

        public Order()
        {
            lineItems = new List<Product> { new Product { Name = "Olma", Weight = 4.5 } };
            

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