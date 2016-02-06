namespace VATTaxCalculator
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class Order containing a List of product IDs and a list of product quantities.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="order">Initializes a new Order object.</param>
        public Order(Dictionary<int, int> order)
        {
            // Separates order to product ids and product quantities
            this.ProductIds = order.Keys.ToList();
            this.ProductQuantities = order.Values.ToList();
        }

        /// <summary>
        /// Gets a list of product IDs.
        /// </summary>
        /// <value>Private setter in constructor.</value>
        public List<int> ProductIds { get; }

        /// <summary>
        /// Gets a list of product quantities.
        /// </summary>
        /// <value>Private setter in constructor.</value>
        public List<int> ProductQuantities { get; }
    }
}
