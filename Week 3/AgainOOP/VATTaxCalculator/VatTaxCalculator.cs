namespace VATTaxCalculator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class VatTaxCalculator containing a Vat tax calculator which calculates prices with vat tax.
    /// </summary>
    public class VatTaxCalculator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatTaxCalculator"/> class.
        /// </summary>
        /// <param name="countryList">Country list.</param>
        public VatTaxCalculator(List<CountryVatTax> countryList)
        {
            this.CountriesList = countryList;
        }

        /// <summary>
        /// Gets the list of countries in the Vat tax calculator class.
        /// </summary>
        /// <value>Setter in constructor.</value>
        public List<CountryVatTax> CountriesList { get; }

        /// <summary>
        /// Calculates the price with a given price and country ID.
        /// </summary>
        /// <param name="price">Initial price.</param>
        /// <param name="countryId">Country ID.</param>
        /// <returns>A new price with calculated VAT tax for country with specified ID.</returns>
        public double CalculateTax(double price, int countryId)
        {
            // Calculates the price with VAT of the country with id - countryId
            foreach (CountryVatTax country in this.CountriesList)
            {
                if (country.CountryId == countryId)
                {
                    // ReSharper disable once PossibleLossOfFraction
                    return price + (price * (country.VatTax / 100));
                }
            }

            Console.WriteLine("ERROR: Country not in country list !");
            return -1;
        }

        /// <summary>
        /// Calculates the price with a given price and without Country ID, using the default country(if any)'s vat tax.
        /// </summary>
        /// <param name="price">Initial price.</param>
        /// <returns>A new price with calculated VAT tax for default country.</returns>
        public double CalculateTax(double price)
        {
            // Calculates the prive with VAT for default country tax
            foreach (CountryVatTax country in this.CountriesList)
            {
                if (country.IsDefault)
                {
                    // ReSharper disable once PossibleLossOfFraction
                    return price + (price * (country.VatTax / 100));
                }
            }

            Console.WriteLine("No Default Country set");
            return -1;
        }
    }
}
