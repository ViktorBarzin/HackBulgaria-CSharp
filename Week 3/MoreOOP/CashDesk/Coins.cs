namespace CashDesk
{
    using System;
    using System.Collections.Generic;

    public class Coin
    {
        private const string STOTINKI = "st";
        private readonly List<int> validCoinValues = new List<int> { 1, 2, 5, 10, 20, 50, 100 };
        private int value;

        public Coin(int value)
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
                // Check if coin is valid
                if (!this.validCoinValues.Contains(value))
                {
                    Console.WriteLine("ERROR: Invalid Value for coin!");
                }
                else
                {
                    this.value = value;
                }
            }
        }

        public static bool operator ==(Coin coin1, Coin coin2)
        {
            return coin2 != null && (coin1 != null && coin1.value == coin2.value);
        }

        public static bool operator !=(Coin coin1, Coin coin2)
        {
            return coin2 != null && (coin1 != null && coin1.value != coin2.value);
        }

        public static explicit operator int(Coin coin)
        {
            int value = (int)coin.value;
            return value;
        }

        public override string ToString()
        {
            // var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return string.Format(this.value + " " + STOTINKI);
        }

        public override bool Equals(object obj)
        {
            if (obj is Coin && this.value == (obj as Coin).value)
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
