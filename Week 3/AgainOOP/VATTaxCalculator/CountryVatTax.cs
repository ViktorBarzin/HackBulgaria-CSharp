namespace VATTaxCalculator
{
    /// <summary>
    /// Class CountryVatTax which holds a country and its Vat tax.
    /// </summary>
    public class CountryVatTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryVatTax"/> class.
        /// </summary>
        /// <param name="id">ID of the country.</param>
        /// <param name="tax">VAT tax of the country.</param>
        /// <param name="isdef">If country is default.</param>
        public CountryVatTax(int id, int tax, bool isdef = false)
        {
            this.CountryId = id;
            this.VatTax = tax;
            this.IsDefault = isdef;
        }

        /// <summary>
        /// Gets Country ID.
        /// </summary>
        /// <value>Private setter in constructor.</value>
        public int CountryId { get; private set; }

        /// <summary>
        /// Gets country VAT tax.
        /// </summary>
        /// <value>Private setter in constructor.</value>
        public int VatTax { get; private set; }

        /// <summary>
        /// Gets a value indicating whether a country is default.
        /// </summary>
        /// <value>Setter is in the constructor and private.</value>
        public bool IsDefault { get; private set; }
    }
}
