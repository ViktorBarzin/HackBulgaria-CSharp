namespace HackCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderProduct
    {
        public OrderProduct(int orderId, int productId)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
        }

        public int OrderId { get; set; }

        public int ProductId { get; set; }
    }
}
