namespace CashDesk
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class BatchCoin containing a list of Coin objects.
    /// </summary>
    public class BatchCoin : IEnumerable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCoin"/> class.
        /// </summary>
        /// <param name="coinList">List of Coins to add in the batchCoin.</param>
        public BatchCoin(List<Coin> coinList)
        {
            this.Count = coinList.Count;
            this.Total = this.Sum();
            this.CoinList = coinList;
        }

        /// <summary>
        /// Gets a list of the coins in the batch coin class.
        /// </summary>
        /// <value>Value is set in the Coins constructor.</value>
        public List<Coin> CoinList { get; }

        /// <summary>
        /// Gets the count of the coins in the batch coin.
        /// </summary>
        /// <value>BatchCoin Count is calculated in the constructor.</value>
        public int Count { get; }

        /// <summary>
        /// Gets the total value of the coins in the batch coin.
        /// </summary>
        /// <value>BatchCoin Total is calculated in the BatchCoin constructor.</value>
        public double Total { get; }

        /// <summary>
        /// Gets an indexer for the current batch coin object.
        /// </summary>
        /// <param name="i">Indexer i.</param>
        /// <returns>Indexer of the BatchCoin class.</returns>
        public Coin this[int i]
        {
            get { return this.CoinList[i]; }
            set { this.CoinList[i] = value; }
        }

        /// <summary>
        /// BatchCoin object to string.
        /// </summary>
        /// <returns>Current instance of BatchCoin as string.</returns>
        public override string ToString()
        {
            return string.Format("Number of coins : {0}, \nTotal value of coins : {1}", this.Count, this.Total);
        }

        /// <summary>
        /// Get enumerator method.
        /// </summary>
        /// <returns>Current instance of BatchCoin coinList enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.CoinList.GetEnumerator();
        }

        /// <summary>
        /// Calculates the total of the coins objects values in the batch coin.
        /// </summary>
        /// <returns>The sum of the values of the Coin objects in current instance of BatchCoin.</returns>
        private double Sum()
        {
            double sum = 0;
            foreach (var coin in this.CoinList)
            {
                sum += coin.Value;
            }

            return sum;
        }
    }
}
