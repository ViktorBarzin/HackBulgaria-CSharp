namespace CashDesk
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BatchBill : IEnumerable
    {
        private int count;
        private int total;
        private List<Bill> billValues = new List<Bill>();

        public BatchBill(List<Bill> billList)
        {
            this.Count = billList.Count;
            this.Total = this.Sum(billList);
            this.billValues = billList;
        }

        public List<Bill> BillValues
        {
            get { return this.billValues; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public int Total
        {
            get { return this.total; }
            private set { this.total = value; }
        }

        public Bill this[int i]
        {
            get { return this.billValues[i]; }
            set { this.billValues[i] = value; }
        }

        public int Sum(List<Bill> billList)
        {
            int sum = 0;
            for (int i = 0; i < billList.Count; i++)
            {
                sum += billList[i].Value;
            }

            return sum;
        }

        public override string ToString()
        {
            return string.Format("Number of bills : {0}, \nTotal value of bills : {1}", this.Count, this.Total);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.billValues.GetEnumerator();
        }
    }
}