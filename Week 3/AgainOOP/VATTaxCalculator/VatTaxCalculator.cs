namespace VATTaxCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VatTaxCalculator
    {
        private List<CountryVatTax> countriesList = new List<CountryVatTax>();

        public VatTaxCalculator(List<CountryVatTax> countryList)
        {
            this.CountriesList = countryList;
        }

        public List<CountryVatTax> CountriesList
        {
            get { return this.countriesList; }

            set { this.countriesList = value; }
        }

        public double CalculateTax(double price, int countryId)
        {
            // Calculates the price with VAT of the country with id - countryId
            foreach (CountryVatTax country in this.countriesList)
            {
                if (country.CountryId == countryId)
                {
                    return price + price * (country.VatTax / 100);
                }
            }

            Console.WriteLine("ERROR: Country not in country list !");
            return -1;
        }

        public double CalculateTax(double price)
        {
            // Calculates the prive with VAT for default country tax
            foreach (CountryVatTax country in this.countriesList)
            {
                if (country.IsDefault)
                {
                    return price + price * (country.VatTax / 100);
                }
            }

            Console.WriteLine("No Default Country se");
            return -1;
        }
    }
}
