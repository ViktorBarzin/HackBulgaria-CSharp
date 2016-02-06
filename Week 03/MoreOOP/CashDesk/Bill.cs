namespace CashDesk
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Bill class.
    /// </summary>
    public class Bill
    {
        /// <summary>
        /// List of valid bill values.
        /// </summary>
        private readonly List<int> validBillValues = new List<int> { 2, 5, 10, 20, 50, 100 };

        /// <summary>
        /// Bill Value.
        /// </summary>
        private int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bill"/> class.
        /// </summary>
        /// <param name="value">Integer to be set as Bill Value.</param>
        public Bill(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the Value of the bill.
        /// </summary>
        /// <value>Private setter.Bill value set in constructor.</value>
        public int Value
        {
            get
            {
                return this.value;
            }

            private set
            {
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

        /// <summary>
        /// Operator == for two Bill objects.
        /// </summary>
        /// <param name="bill1">Bill object one.</param>
        /// <param name="bill2">Bill object two.</param>
        /// <returns>True if the Bill objects are equal.</returns>
        public static bool operator ==(Bill bill1, Bill bill2)
        {
            return bill2 != null && (bill1 != null && bill1.value == bill2.value);
        }

        /// <summary>
        /// Operator != for two Bill objects.
        /// </summary>
        /// <param name="bill1">Bill object one.</param>
        /// <param name="bill2">Bill object two.</param>
        /// <returns>True if the Bill objects are not equal.</returns>
        public static bool operator !=(Bill bill1, Bill bill2)
        {
            return bill2 != null && (bill1 != null && bill1.value != bill2.value);
        }

        /// <summary>
        /// Explicit casting Bill objects to integer.
        /// </summary>
        /// <param name="bill">A bill to be cast to integer.</param>
        public static explicit operator int(Bill bill)
        {
            int value = (int)bill.value;
            return value;
        }

        /// <summary>
        /// Bill object as a string.
        /// </summary>
        /// <returns>Bill object as String.</returns>
        public override string ToString()
        {
            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return string.Format(this.value.ToString() + " " + ri.ISOCurrencySymbol);
        }

        /// <summary>
        /// Overrides Equals method for Bill class.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if Bill object and input object are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Bill && this.value == (obj as Bill).value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides GetHashCode() method for Bill class.
        /// </summary>
        /// <returns>HashCode for Bill object.</returns>
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
