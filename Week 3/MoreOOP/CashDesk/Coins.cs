namespace CashDesk
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Coin class.
    /// </summary>
    public class Coin
    {
        /// <summary>
        /// Stotinki string constant.
        /// </summary>
        private const string STOTINKI = "st";

        /// <summary>
        /// List of valid bill values.
        /// </summary>
        private readonly List<int> validCoinValues = new List<int> { 1, 2, 5, 10, 20, 50, 100 };

        /// <summary>
        /// Initializes a new instance of the <see cref="Coin"/> class.
        /// </summary>
        /// <param name="value">Integer to be set as Coin Value.</param>
        public Coin(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the Value of the coin.
        /// </summary>
        /// <value>Private setter.Coin value set in constructor.</value>
        public int Value
        {
            get
            {
                return this.Value;
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
                    this.Value = value;
                }
            }
        }

        /// <summary>
        /// Operator == for two Coin objects.
        /// </summary>
        /// <param name="coin1">Coin object one.</param>
        /// <param name="coin2">Coin object two.</param>
        /// <returns>True if the Coin objects are equal.</returns>
        public static bool operator ==(Coin coin1, Coin coin2)
        {
            return coin2 != null && (coin1 != null && coin1.Value == coin2.Value);
        }

        /// <summary>
        /// Operator != for two Coin objects.
        /// </summary>
        /// <param name="coin1">Coin object one.</param>
        /// <param name="coin2">Coin object two.</param>
        /// <returns>True if the Coin objects are not equal.</returns>
        public static bool operator !=(Coin coin1, Coin coin2)
        {
            return coin2 != null && (coin1 != null && coin1.Value != coin2.Value);
        }

        /// <summary>
        /// Explicit casting Coin objects to integer.
        /// </summary>
        /// <param name="coin">A coin to be cast to integer.</param>
        public static explicit operator int(Coin coin)
        {
            return coin.Value;
        }

        /// <summary>
        /// Coin object as a string.
        /// </summary>
        /// <returns>Coin object as String.</returns>
        public override string ToString()
        {
            // var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return string.Format(this.Value + " " + STOTINKI);
        }

        /// <summary>
        /// Overrides Equals method for Coin class.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if Coin object and input object are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Coin && this.Value == (obj as Coin).Value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides GetHashCode() method for Coin class.
        /// </summary>
        /// <returns>HashCode for Coin object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.Value.GetHashCode();
                return hash;
            }
        }
    }
}
