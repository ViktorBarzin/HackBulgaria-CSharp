namespace VATTaxCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShopInventory
    {
        private readonly Dictionary<Product, int> productsList = new Dictionary<Product, int>();

        public ShopInventory(Product productToAdd)
        {
            // Checks if product exists, if so, increments its quantity by 1, else adds as new item
            if (!this.productsList.Keys.Contains(productToAdd))
            {
                this.productsList.Add(productToAdd, 1);
            }
            else
            {
                this.productsList[productToAdd]++;
            }
        }

        public ShopInventory(IEnumerable<Product> listOfProducts)
        {
            // Adds each product via the aforementioned logic
            foreach (Product prod in listOfProducts)
            {
                if (!this.productsList.Keys.Contains(prod))
                {
                    this.productsList.Add(prod, 1);
                }
                else
                {
                    this.productsList[prod]++;
                }
            }
        }

        public double Audit()
        {
            // Sums all the product values times their quantity
            double sum = 0;
            foreach (Product product in this.productsList.Keys)
            {
                sum += product.PriceWithoutTax * product.Quantity;
            }

            return sum;
        }

        public double RequestOrder(Order order)
        {
            // Takes an order and returns the order price
            double sum = (from id in order.ProductIds
                          from prod in this.productsList.Keys
                          where prod.ProductId == id && order.ProductQuantities[order.ProductIds.IndexOf(id)] <= prod.Quantity
                          select prod.PriceWithTax * order.ProductQuantities[order.ProductIds.IndexOf(id)]).Sum();

            if (Math.Abs(sum) > 0.001)
            {
                return sum;
            }

            Console.WriteLine("ERROR: None of the items you ordered are available in the requested quantities !");
            return -1;
        }
    }
}
