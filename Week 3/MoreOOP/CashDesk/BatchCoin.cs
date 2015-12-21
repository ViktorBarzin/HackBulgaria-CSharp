namespace CashDesk
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BatchCoin : IEnumerable
    {
        public BatchCoin(List<Coin> coinList)
        {
            this.Count = coinList.Count;
            this.Total = this.Sum(coinList);
            this.CoinValues = coinList;
        }

        public List<Coin> CoinValues { get; }

        public int Count { get; set; }

        public double Total { get; private set; }

        public Coin this[int i]
        {
            get { return this.CoinValues[i]; }
            set { this.CoinValues[i] = value; }
        }

        public double Sum(List<Coin> coinList)
        {
            return coinList.Aggregate<Coin, double>(0, (current, t) => current + t.Value);
        }

        public override string ToString()
        {
            return string.Format("Number of coins : {0}, \nTotal value of coins : {1}", this.Count, this.Total);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.CoinValues.GetEnumerator();
        }
    }
}
