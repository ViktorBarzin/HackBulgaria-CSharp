﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class ShopInventory
    {
        private Dictionary<Product,int> productsList = new Dictionary<Product, int>();
        public ShopInventory(Product productToAdd)
        {
            if (!productsList.Keys.Contains(productToAdd))
            {
                productsList.Add(productToAdd,1);
            }
            else
            {
                productsList[productToAdd]++;
            }
        }
        public ShopInventory(List<Product> listOfProducts)
        {
            foreach (Product prod in listOfProducts)
            {
                if (!productsList.Keys.Contains(prod))
                {
                    productsList.Add(prod, 1);
                }
                else
                {
                    productsList[prod]++;
                }
            }
        }

       

        public double Audit()
        {
            double sum = 0;
            foreach (Product product in this.productsList.Keys)
            {
                sum += (product.PriceWithoutTax * product.Quantity);
            }
            return sum;
        }
        public double RequestOrder(Order order)
        {
            double sum = 0;
            foreach (int id in order.ProductIds)
            {
                foreach (Product prod in productsList.Keys)
                {
                    //Possible conflicts
                    if (prod.ProductId == id && order.ProductQuantities[order.ProductIds.IndexOf(id)] <= prod.Quantity)
                    {
<<<<<<< HEAD
                        //&& order.ProductQuantities[order.ProductIds.IndexOf(id)] <= productsList.Values.ToList()[order.ProductIds.IndexOf(id)]
=======
                        //<= productsList.Values.ToList()[productsList.Keys.ToList().IndexOf(prod)]
                        //Console.WriteLine(order.ProductQuantities.ToList()[prod.ProductId - 1]);
>>>>>>> b0df35290d68d8a7be58943ec07097f887207060
                        sum += prod.PriceWithTax * order.ProductQuantities[order.ProductIds.IndexOf(id)];
                    }
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("ERROR: None of the items you ordered are available in the requested quantities !");
                return 0;
            }
            return sum;
            //throw new ArgumentException(string.Format("ERROR: Too few or none products with id {0} left in inventory !"));
        }

    }
}
