namespace CashDesk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CashDesk
    {
        private readonly List<int> validBillValues = new List<int> { 2, 5, 10, 20, 50, 100 };
        private readonly List<int> validCoinValues = new List<int> { 1, 2, 5, 10, 20, 50, 100 };
        private Dictionary<int, int> bills = new Dictionary<int, int>();
        private Dictionary<int, int> coins = new Dictionary<int, int>();

        public CashDesk()
        {
            this.BillTotalProp = this.bills.Keys.Sum();
            this.CoinTotalProp = this.coins.Keys.Sum();
        }

        private int BillTotalProp { get; set; }

        private double CoinTotalProp { get; set; }

        public CashDesk TakeMoney(Bill singleBill)
        {
            // Check if bill is valid then add it to CashDesk
            if (this.validBillValues.Contains(singleBill.Value))
            {
                this.BillTotalProp += singleBill.Value;
                if (!this.bills.ContainsKey(singleBill.Value))
                {
                    this.bills.Add(singleBill.Value, 1);
                }
                else
                {
                    this.bills[singleBill.Value]++;
                }

                Console.WriteLine("SUCCESS: added {0} bill !", new Bill(singleBill.Value));
            }

            return this;
        }

        public CashDesk TakeMoney(BatchBill batchList)
        {
            // Remove the following code to add all but the not legit bill
            bool isLegit = true;
            foreach (Bill billToAdd in batchList.Cast<Bill>().Where(billToAdd => !this.validBillValues.Contains(billToAdd.Value)))
            {
                isLegit = false;
            }

            ////
            foreach (Bill bill in batchList.Cast<Bill>().Where(bill => isLegit))
            {
                if (!this.bills.ContainsKey(bill.Value))
                {
                    this.bills.Add(bill.Value, 1);
                    this.BillTotalProp += bill.Value;
                }
                else
                {
                    this.bills[bill.Value]++;
                    this.BillTotalProp += bill.Value;
                }
            }

            if (isLegit)
            {
                Console.WriteLine("SUCCESS: added new batch of bills !");
            }

            return this;
        }

        public CashDesk RemoveMoney(Bill singleBill)
        {
            // If bill exists, removes it from CashDesk
            if (this.bills.Keys.Contains(singleBill.Value))
            {
                this.bills.Remove(singleBill.Value);
                this.BillTotalProp -= singleBill.Value;
                Console.WriteLine("SUCCES: removed {0} bill !", singleBill.ToString());
            }
            else
            {
                Console.WriteLine("ERROR: bills list does not contain a {0} bill !", singleBill.ToString());
            }

            return this;
        }

        public CashDesk RemoveMoney(BatchBill batchList)
        {
            // Removes a list of Bills
            foreach (Bill bill in batchList)
            {
                if (!this.bills.ContainsKey(bill.Value))
                {
                    Console.WriteLine("ERROR: could not find a {0} bill to remove !", bill.ToString());
                }
                else
                {
                    this.bills.Remove(bill.Value);
                    this.BillTotalProp -= bill.Value;
                    Console.WriteLine("SUCCES: Removed {0} !", bill.Value);
                }
            }

            return this;
        }

        public CashDesk RemoveAllBills()
        {
            this.bills = new Dictionary<int, int>();
            this.BillTotalProp = 0;
            return this;
        }

        public CashDesk TakeMoney(Coin singleCoin)
        {
            // Adds single coin to CashDesk if coin is valid
            if (this.validCoinValues.Contains(singleCoin.Value))
            {
                this.CoinTotalProp += singleCoin.Value;
                if (!this.coins.ContainsKey(singleCoin.Value))
                {
                    this.coins.Add(singleCoin.Value, 1);
                }
                else
                {
                    this.coins[singleCoin.Value]++;
                }

                Console.WriteLine("SUCCESS: added {0} coin !", new Coin(singleCoin.Value));
            }

            return this;
        }

        public CashDesk TakeMoney(BatchCoin batchCoin)
        {
            // Remove the following code to add all but the not legit bill
            bool isLegit = batchCoin.Cast<Coin>().All(coinToAdd => this.validCoinValues.Contains(coinToAdd.Value));

            // Adds all coins if valid
            foreach (Coin coin in batchCoin.Cast<Coin>().Where(coin => isLegit))
            {
                if (!this.coins.ContainsKey(coin.Value))
                {
                    this.coins.Add(coin.Value, 1);
                    this.CoinTotalProp += coin.Value;
                }
                else
                {
                    this.coins[coin.Value]++;
                    this.CoinTotalProp += coin.Value;
                }
            }

            return this;
        }

        public CashDesk RemoveMoney(Coin singleCoin)
        {
            // If coin exists in CashDesk, removes it
            if (this.coins.Keys.Contains(singleCoin.Value))
            {
                this.coins.Remove(singleCoin.Value);
                this.CoinTotalProp -= singleCoin.Value;
                Console.WriteLine("SUCCES: removed {0} coin !", singleCoin.ToString());
            }
            else
            {
                Console.WriteLine("ERROR: coins list does not contain a {0} coin !", singleCoin.ToString());
            }

            return this;
        }

        public CashDesk RemoveMoney(BatchCoin batchCoin)
        {
            // Removes a list of Coins if all coins are present in the CashDesk
            foreach (Coin coin in batchCoin)
            {
                if (!this.coins.ContainsKey(coin.Value))
                {
                    Console.WriteLine("ERROR: could not find a {0} coin to remove !", coin.ToString());
                }
                else
                {
                    this.coins.Remove(coin.Value);
                    this.CoinTotalProp -= coin.Value;
                    Console.WriteLine("SUCCES: Removed {0} !", coin.Value);
                }
            }

            return this;
        }

        public CashDesk RemoveAllCoins()
        {
            this.CoinTotalProp = 0;
            this.coins = new Dictionary<int, int>();
            return this;
        }

        public double Total()
        {
            return this.BillTotalProp + (this.CoinTotalProp / 100);
        }

        public CashDesk Inspect()
        {
            // List CashDesk money in sorted manner
            if (this.bills.Count == 0 && this.coins.Count == 0)
            {
                Console.WriteLine("You dont have any money !");
            }
            else
            {
                var sortedCoins = from pair in this.coins orderby pair.Key descending select pair;
                var sortedBills = from pair in this.bills orderby pair.Key descending select pair;
                foreach (var item in sortedBills)
                {
                    Console.WriteLine("{0} bills - {1}", new Bill(item.Key), item.Value);
                }

                foreach (var coin in sortedCoins)
                {
                    Console.WriteLine("{0} coins - {1}", new Coin(coin.Key), coin.Value);
                }
            }

            return this;
        }
    }
}
