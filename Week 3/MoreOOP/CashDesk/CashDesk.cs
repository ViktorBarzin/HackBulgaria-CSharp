using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDesk
    {
        private int billTotal;
        private double coinTotal;
        private Dictionary<int, int> bills = new Dictionary<int, int>();
        private Dictionary<int, int> coins = new Dictionary<int, int>();
        public List<int> ValidBillValues = new List<int> { 2, 5, 10, 20, 50, 100 };
        public List<int> ValidCoinValues = new List<int> { 1, 2, 5, 10, 20, 50, 100 };

        public CashDesk()
        {
            this.BillTotalProp = bills.Keys.Sum();
            this.CoinTotalProp = coins.Keys.Sum();
        }
        private int BillTotalProp
        {
            get { return this.billTotal; }
            set { this.billTotal = value; }
        }
        private double CoinTotalProp
        {
            get { return this.coinTotal; }
            set { this.coinTotal = value; }
        }

        public CashDesk TakeMoney(Bill singleBill)
        {
            if (ValidBillValues.Contains(singleBill.Value))
            {
                this.BillTotalProp += singleBill.Value;
                if (!bills.ContainsKey(singleBill.Value))
                {
                    bills.Add(singleBill.Value, 1);
                }
                else
                {
                    bills[singleBill.Value]++;
                }
                Console.WriteLine("SUCCESS: added {0} bill !", new Bill(singleBill.Value));

            }
            return this;
        }
        public CashDesk TakeMoney(BatchBill batchList)
        {
            //Remove the following code to add all but the not legit bill
            bool IsLegit = true;
            foreach (Bill billToAdd in batchList)
            {
                if (!ValidBillValues.Contains(billToAdd.Value))
                {
                    IsLegit = false;
                }
            }
            //
            foreach (Bill bill in batchList)
            {

                if (IsLegit)
                {
                    if (!bills.ContainsKey(bill.Value))
                    {
                        bills.Add(bill.Value, 1);
                        this.BillTotalProp += bill.Value;
                    }
                    else
                    {
                        bills[bill.Value]++;
                        this.BillTotalProp += bill.Value;
                    }
                }
            }
            if (IsLegit)
            {
                Console.WriteLine("SUCCESS: added new batch of bills !");
            }
            return this;
        }
        public CashDesk RemoveMoney(Bill singleBill)
        {
            if (bills.Keys.Contains(singleBill.Value))
            {
                bills.Remove(singleBill.Value);
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
            foreach (Bill bill in batchList)
            {
                if (!bills.ContainsKey(bill.Value))
                {
                    Console.WriteLine("ERROR: could not find a {0} bill to remove !", bill.ToString());
                }
                else
                {
                    bills.Remove(bill.Value);
                    this.BillTotalProp -= bill.Value;
                    Console.WriteLine("SUCCES: Removed {0} !",bill.Value);
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
            if (ValidCoinValues.Contains(singleCoin.Value))
            {
                this.CoinTotalProp += singleCoin.Value;
                if (!coins.ContainsKey(singleCoin.Value))
                {
                    coins.Add(singleCoin.Value, 1);
                }
                else
                {
                    coins[singleCoin.Value]++;
                }
                Console.WriteLine("SUCCESS: added {0} coin !", new Coin(singleCoin.Value));
            }
            return this;
        }
        public CashDesk TakeMoney(BatchCoin batchCoin)
        {
            //Remove the following code to add all but the not legit bill
            bool IsLegit = true;
            foreach (Coin coinToAdd in batchCoin)
            {
                if (!ValidCoinValues.Contains(coinToAdd.Value))
                {
                    IsLegit = false;
                    break;
                }
            }
            //
            foreach (Coin coin in batchCoin)
            {

                if (IsLegit)
                {
                    if (!coins.ContainsKey(coin.Value))
                    {
                        coins.Add(coin.Value, 1);
                        this.CoinTotalProp += coin.Value;
                    }
                    else
                    {
                        coins[coin.Value]++;
                        this.CoinTotalProp += coin.Value;
                    }
                }
            }
            return this;
        }
        public CashDesk RemoveMoney(Coin singleCoin)
        {
            if (coins.Keys.Contains(singleCoin.Value))
            {
                coins.Remove(singleCoin.Value);
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
            foreach (Coin coin in batchCoin)
            {
                if (!coins.ContainsKey(coin.Value))
                {
                    Console.WriteLine("ERROR: could not find a {0} coin to remove !", coin.ToString());
                }
                else
                {
                    coins.Remove(coin.Value);
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
            return this.billTotal + this.coinTotal / 100;
        }
        public CashDesk Inspect()
        {
            if (bills.Count == 0 && coins.Count == 0)
            {
                Console.WriteLine("You dont have any money !");
            }
            else
            {
                foreach (var item in bills)
                {
                    Console.WriteLine("{0} bills - {1}", new Bill(item.Key), item.Value);
                }
                foreach (var coin in coins)
                {
                    Console.WriteLine("{0} coins - {1}", new Coin(coin.Key), coin.Value);
                }
            }
            return this;
        }
        //public BatchBill GiveChange(BatchCoin coinList)
        //{
        //    this.TakeMoney(coinList);
        //    double coinsSum = coinList.Total;
        //    List<Bill> billToReturn = new List<Bill>();
        //    while (coinsSum > 0)
        //    {
        //        if (ValidBillValues.Contains((int)coinsSum))
        //        {
        //            billToReturn.Add(new Bill((int)coinsSum));
        //        }
        //        coinsSum -= ValidCoinValues[0];
        //    }
        //    //knapsack problem ?
        //    return 
        //}

    }
}
