using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATTaxCalculator;
namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryVatTax bg = new CountryVatTax(1, 20);
            CountryVatTax ger = new CountryVatTax(2, 30, true);
            CountryVatTax gb = new CountryVatTax(3, 40);
            CountryVatTax hol = new CountryVatTax(4, 50);
            CountryVatTax usa = new CountryVatTax(5, 60);

            List<CountryVatTax> countriesList = new List<CountryVatTax>() {bg,ger,gb,hol,usa };

            VatTaxCalculator calc = new VatTaxCalculator(countriesList);

            //Id, Name,quantity, price, country
            Product prod1 = new Product(0, "prod1", 5, 10, bg);
            Product prod2 = new Product(2, "prod2", 2, 20, bg);
            Product prod3 = new Product(5, "prod3", 1, 50, bg);
            List<Product> productsList = new List<Product>() { prod1, prod2, prod3 };

            ShopInventory newInventory = new ShopInventory(productsList);

            //order - id,quantity
            Dictionary<int, int> orderdict = new Dictionary<int, int>();
            orderdict.Add(0, 6);
            //orderdict.Add(2, 2);
            Order newOrder = new Order(orderdict);
            Console.WriteLine(newInventory.RequestOrder(newOrder));
            
        }
    }
}
