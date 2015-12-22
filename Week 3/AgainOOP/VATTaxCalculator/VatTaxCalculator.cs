namespace VATTaxCalculator
{
    using System;
    using System.Collections.Generic;

    public class VatTaxCalculator
    {
        public VatTaxCalculator(List<CountryVatTax> countryList)
        {
            this.CountriesList = countryList;
        }

        public List<CountryVatTax> CountriesList { get; set; }

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
