namespace VATTaxCalculator
{
    public class CountryVatTax
    {
        public CountryVatTax(int id, int tax, bool isdef = false)
        {
            this.CountryId = id;
            this.VatTax = tax;
            this.IsDefault = isdef;
        }

        public int CountryId { get; set; }

        public int VatTax { get; set; }

        public bool IsDefault { get; set; }
    }
}
