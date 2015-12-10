namespace CashDesk
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bill
    {
        // TODO : implement generics support
        private List<int> validBillValues = new List<int> { 2, 5, 10, 20, 50, 100 };
        private int value;

        public Bill(int value)
        {
            this.Value = value;
        }

        public int Value
        {
            get
            {
                return this.value;
            }

            set
            {
                // Check if bill is valid
                if (!this.validBillValues.Contains(value))
                {
                    Console.WriteLine("ERROR: Invalid Value for bill!");
                }
                else
                {
                    this.value = value;
                }
            }
        }

        public static bool operator ==(Bill bill1, Bill bill2)
        {
            if (bill1.value == bill2.value)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Bill bill1, Bill bill2)
        {
            if (bill1.value != bill2.value)
            {
                return true;
            }

            return false;
        }

        public static explicit operator int(Bill bill)
        {
            int value = (int)bill.value;
            return value;
        }

        public override string ToString()
        {
            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            string res = this.value.ToString() + " " + ri.ISOCurrencySymbol;

            return res;
        }

        public override bool Equals(object obj)
        {
            if (obj is Bill && this.value == (obj as Bill).value)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.value.GetHashCode();
                return hash;
            }
        }
    }
}
