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
        /// <param name="coinList">List of Coins to add in the batchCoin</param>
        public BatchCoin(List<Coin> coinList)
        {
            this.Count = coinList.Count;
            this.Total = this.Sum(coinList);
            this.CoinValues = coinList;
        }

        /// <summary>
        /// Gets a list of the coins in the batch coin class.
        /// </summary>
        public List<Coin> CoinValues { get; }

        /// <summary>
        /// Gets the count of the coins in the batch coin.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets the total value of the coins in the batch coin.
        /// </summary>
        public double Total { get; private set; }

        /// <summary>
        /// Gets an indexer for the current batch coin object.
        /// </summary>
        /// <param name="i">Indexer.</param>
        /// <returns>Indexer of the coinList.</returns>
        public Coin this[int i]
        {
            get { return this.CoinValues[i]; }
            set { this.CoinValues[i] = value; }
        }

        /// <summary>
        /// Calculates the total of the coins objects values in the batch coin.
        /// </summary>
        /// <returns>The sum of the values of the Coin objects in current instance of BatchCoin.</returns>
        public double Sum(List<Coin> coinList)
        {
            return coinList.Aggregate<Coin, double>(0, (current, coin) => current + coin.Value);
        }

        /// <summary>
        /// BatchCoin object to string.
        /// </summary>
        /// <returns>Current instance of BacthCoin as string.</returns>
        public override string ToString()
        {
            return string.Format("Number of coins : {0}, \nTotal value of coins : {1}", this.Count, this.Total);
        }

        /// <summary>
        /// Get enumerator method.
        /// </summary>
        /// <returns>Current instance of BachtCoin coinList enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.CoinValues.GetEnumerator();
        }
    }
}
