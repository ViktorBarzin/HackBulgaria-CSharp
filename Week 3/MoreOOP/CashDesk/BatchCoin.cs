namespace CashDesk
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BatchCoin : IEnumerable
    {
        private int count;
        private double total;
        private List<Coin> coinValues = new List<Coin>();

        public BatchCoin(List<Coin> coinList)
        {
            this.Count = coinList.Count;
            this.Total = this.Sum(coinList);
            this.coinValues = coinList;
        }

        public List<Coin> CoinValues
        {
            get { return this.coinValues; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public double Total
        {
            get { return this.total; }
            private set { this.total = value; }
        }

        public Coin this[int i]
        {
            get { return this.coinValues[i]; }
            set { this.coinValues[i] = value; }
        }

        public double Sum(List<Coin> coinList)
        {
            double sum = 0;
            for (int i = 0; i < coinList.Count; i++)
            {
                sum += coinList[i].Value;
            }

            return sum;
        }

        public override string ToString()
        {
            return string.Format("Number of coins : {0}, \nTotal value of coins : {1}", this.Count, this.Total);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.coinValues.GetEnumerator();
        }
    }
}
