namespace VATTaxCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountryVatTax
    {
        private int countryId;
        private int vattax;
        private bool isDefault;

        public CountryVatTax(int id, int tax, bool isdef = false)
        {
            this.CountryId = id;
            this.VatTax = tax;
            this.IsDefault = isdef;
        }

        public int CountryId
        {
            get { return this.countryId; }
            set { this.countryId = value; }
        }

        public int VatTax
        {
            get { return this.vattax; }
            set { this.vattax = value; }
        }

        public bool IsDefault
        {
            get
            {
                return this.isDefault;
            }

            set
            {
                this.isDefault = value;
            }
        }
    }
}
