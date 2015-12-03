using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CashDesk
{
    public class Bill
    {
        private int value;
        public Bill(int value)
        {
            this.Value = value;
        }
        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
            }
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
    }
}
