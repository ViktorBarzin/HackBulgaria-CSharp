namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VATTaxCalculator;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Add CountryVatTax countries - id, vat, isDefault
            CountryVatTax bg = new CountryVatTax(1, 20, true);

            // Add countries to list
            List<CountryVatTax> countriesList = new List<CountryVatTax>() { bg };

            // Initialise VatTaxCalculator with the countries list 
            VatTaxCalculator calc = new VatTaxCalculator(countriesList);

            // Add products - id, name, quantity, price, country
            Product prod1 = new Product(0, "prod", 5, 10, bg);

            // Add products to list
            List<Product> productsList = new List<Product>() { prod1 };

            // Initialise a new Inventory with the products list
            ShopInventory newInventory = new ShopInventory(productsList);

            // Add product id and quantity to orderdict 
            Dictionary<int, int> orderdict = new Dictionary<int, int>();
            orderdict.Add(0, 2);

            Order newOrder = new Order(orderdict);
        }
    }
}
