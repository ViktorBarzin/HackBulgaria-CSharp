namespace VATTaxCalculator
{
    using System.Collections.Generic;

    public class Product
    {
        public Product(int prodId, string prodName, int prodQuantity, double price, CountryVatTax countryAvai)
        {
            this.ProductId = prodId;
            this.Quantity = prodQuantity;
            this.NameOfProduct = prodName;
            this.PriceWithoutTax = price;
            this.PriceWithTax = new VatTaxCalculator(new List<CountryVatTax>() { countryAvai }).CalculateTax(price, countryAvai.CountryId);
        }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string NameOfProduct { get; set; }

        public double PriceWithoutTax { get; set; }

        public double PriceWithTax { get; }
    }
}
