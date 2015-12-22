namespace VATTaxCalculator
{
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        public Order(Dictionary<int, int> order)
        {
            // Separates order to product ids and product quantities
            this.ProductIds = order.Keys.ToList();
            this.ProductQuantities = order.Values.ToList();
        }

        public List<int> ProductIds { get; set; }

        public List<int> ProductQuantities { get; set; }
    }
}
