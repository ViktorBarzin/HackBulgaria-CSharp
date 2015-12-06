using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
    public class Product
    {
        private int productId;
        private int quantity;
        private string nameOfProduct;
        private double priceWithoutTax;
        private double priceWithTax;
        private CountryVatTax countryAvailable;

        public Product(int prodId, string prodName, int prodQuantity, double price, CountryVatTax countryAvai)
        {
            this.ProductId = prodId;
            this.Quantity = prodQuantity;
            this.NameOfProduct = prodName;
            this.PriceWithoutTax = price;
            this.priceWithTax = new VatTaxCalculator(new List<CountryVatTax>() { countryAvai}).CalculateTax(price,countryAvai.CountryId);
            this.countryAvailable = countryAvai;
        }
        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public string NameOfProduct
        {
            get { return this.nameOfProduct; }
            set { this.nameOfProduct = value; }
        }
        public double PriceWithoutTax
        {
            get { return this.priceWithoutTax; }
            set { this.priceWithoutTax = value; }
        }
        public double PriceWithTax
        {
            get {return  this.priceWithTax; }
        }
    }
}
