namespace VATTaxCalculator
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Product containing product ID, product quantity, product name, product price, product availability.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="prodId">Sets the product ID.</param>
        /// <param name="prodName">Sets the product name.</param>
        /// <param name="prodQuantity">Sets the product available quantity.</param>
        /// <param name="price">Sets the product price.</param>
        /// <param name="countryAvai">Sets the product country where is is available.</param>
        public Product(int prodId, string prodName, int prodQuantity, double price, CountryVatTax countryAvai)
        {
            this.ProductId = prodId;
            this.Quantity = prodQuantity;
            this.NameOfProduct = prodName;
            this.PriceWithoutTax = price;
            this.PriceWithTax = new VatTaxCalculator(new List<CountryVatTax>() { countryAvai }).CalculateTax(price, countryAvai.CountryId);
        }

        /// <summary>
        /// Gets Product ID.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public int ProductId { get; }

        /// <summary>
        /// Gets Product Quantity.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public int Quantity { get; }

        /// <summary>
        /// Gets Product Name.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public string NameOfProduct { get; }

        /// <summary>
        /// Gets Product Price without Tax.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double PriceWithoutTax { get; }

        /// <summary>
        /// Gets Product Price with Tax.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public double PriceWithTax { get; }
    }
}
