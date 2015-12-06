using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTaxCalculator
{
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
            foreach (CountryVatTax country in countriesList)
            {
                if (country.CountryId == countryId)
                {
                    return price + (price * country.VatTax) / 100;
                }
            }
            throw new NotSupportedException("ERROR: Country not in country list !");
        }
        public double CalculateTax(double price)
        {
            foreach (CountryVatTax country in countriesList)
            {
                if (country.IsDefault)
                {
                    return price + (price * country.VatTax) / 100;
                }
            }
            throw new NotSupportedException("No Default Country set");
        }
    }
}
