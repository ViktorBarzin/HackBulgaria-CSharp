namespace LINQ
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="id">Sets order id.</param>
        /// <param name="products">Sets order products.</param>
        /// <param name="orderDate">Sets order date.</param>
        public Order(int id, List<int> products, DateTime orderDate)
        {
            this.Id = id;
            this.Products = products;
            this.OrderDate = orderDate;
        }

        /// <summary>
        /// Gets or sets order ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets order products..
        /// </summary>  
        public List<int> Products { get; set; }

        /// <summary>
        /// Gets or sets order date.
        /// </summary>
        public DateTime OrderDate { get; set; }
    }
}
