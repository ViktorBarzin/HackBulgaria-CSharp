namespace CashDesk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CashDesk class.
    /// </summary>
    public class CashDesk
    {
        /// <summary>
        /// List of valid bill values.
        /// </summary>
        private readonly List<int> validBillValues = new List<int> { 2, 5, 10, 20, 50, 100 };

        /// <summary>
        /// List of valid coin values.
        /// </summary>
        private readonly List<int> validCoinValues = new List<int> { 1, 2, 5, 10, 20, 50, 100 };

        /// <summary>
        /// List of bill values and their respective count.
        /// </summary>
        private Dictionary<int, int> bills = new Dictionary<int, int>();

        /// <summary>
        /// List of coin values and their respective count.
        /// </summary>
        private Dictionary<int, int> coins = new Dictionary<int, int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CashDesk"/> class.
        /// </summary>
        public CashDesk()
        {
            this.BillTotalProp = this.bills.Keys.Sum();
            this.CoinTotalProp = this.coins.Keys.Sum();
        }

        /// <summary>
        /// Gets the total value of the Bill values in the CashDesk object.
        /// </summary>
        /// <value>Value is set after adding new Bill objects.</value>
        public int BillTotalProp { get; private set; }

        /// <summary>
        /// Gets the total value of the Coin values in the CashDesk object.
        /// </summary>
        /// <value>Value is set after adding new Coin objects.</value>
        public double CoinTotalProp { get; private set; }

        /// <summary>
        /// Adds a Bill object to the CashDesk object.
        /// </summary>
        /// <param name="singleBill">Bill object to add.</param>
        public void TakeMoney(Bill singleBill)
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
        }

        /// <summary>
        /// Adds multiple Bill objects to the CashDesk object.
        /// </summary>
        /// <param name="batchList">Multiple bills to add.</param>
        public void TakeMoney(BatchBill batchList)
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
        }

        /// <summary>
        /// Removes a single bill from the CashDesk object.
        /// </summary>
        /// <param name="singleBill">Bill to remove.</param>
        public void RemoveMoney(Bill singleBill)
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
        }

        /// <summary>
        /// Removes a list of bills if they exist in the CashDesk object.
        /// </summary>
        /// <param name="batchList">List of bills to remove.</param>
        public void RemoveMoney(BatchBill batchList)
        {
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
        }

        /// <summary>
        /// Removes all the bills from the CashDesk object.
        /// </summary>
        public void RemoveAllBills()
        {
            this.bills = new Dictionary<int, int>();
            this.BillTotalProp = 0;
        }

        /// <summary>
        /// Adds a Coin object to the CashDesk object.
        /// </summary>
        /// <param name="singleCoin">Single Coin object to add if valid.</param>
        public void TakeMoney(Coin singleCoin)
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
        }

        /// <summary>
        /// Adds a list of Coin objects to the CashDesk object.
        /// </summary>
        /// <param name="batchCoin">List of Coin objects to add if valid.</param>
        public void TakeMoney(BatchCoin batchCoin)
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
        }

        /// <summary>
        /// Removes a single Coin object from the CashDesk object.
        /// </summary>
        /// <param name="singleCoin">Single Coin object to remove.</param>
        public void RemoveMoney(Coin singleCoin)
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
        }

        /// <summary>
        /// Removes a list of Coin objects from the CashDesk object if they exist.
        /// </summary>
        /// <param name="batchCoin">List of coin objects to remove.</param>
        public void RemoveMoney(BatchCoin batchCoin)
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
        }

        /// <summary>
        /// Removes all Coin objects from the CashDesk object.
        /// </summary>
        public void RemoveAllCoins()
        {
            this.CoinTotalProp = 0;
            this.coins = new Dictionary<int, int>();
        }

        /// <summary>
        /// Shows the total Amount of money in the CashDesk object.
        /// </summary>
        /// <returns>The sum of all Bill values and Coin value.</returns>
        public double Total()
        {
            return this.BillTotalProp + (this.CoinTotalProp / 100);
        }

        /// <summary>
        /// Displays the current amount of values in the CashDesk object in sorted manner.
        /// </summary>
        public void Inspect()
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
        }
    }
}
