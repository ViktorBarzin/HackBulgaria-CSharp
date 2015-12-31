namespace CashDesk
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class BatchBill containing a list of Bill objects.
    /// </summary>
    public class BatchBill : IEnumerable
    {
        /// <summary>
        /// List of Bills.
        /// </summary>
        private readonly List<Bill> billList;

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchBill"/> class.
        /// </summary>
        /// <param name="billList">List of Bills to add in the batchBill</param>
        public BatchBill(List<Bill> billList)
        {
            this.Count = billList.Count;
            this.Total = this.Sum();
            this.billList = billList;
        }

        /// <summary>
        /// Gets a list of the bills in the batch bill class.
        /// </summary>
        public List<Bill> BillValues => this.billList;

        /// <summary>
        /// Gets the count of the bills in the batch bill.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets the total value of the bills in the batch bill.
        /// </summary>
        public int Total { get; private set; }

        /// <summary>
        /// Gets an indexer for the current batch bill object.
        /// </summary>
        /// <param name="i">Indexer.</param>
        /// <returns>Indexer of the billList.</returns>
        public Bill this[int i]
        {
            get { return this.billList[i]; }
            set { this.billList[i] = value; }
        }

        /// <summary>
        /// Calculates the total of the bills objects values in the batch bill.
        /// </summary>
        /// <returns>The sum of the values of the Batch objects in current instance of BatchBill.</returns>
        private int Sum()
        {
            int sum = 0;
            foreach (var bill in this.billList)
            {
                sum += bill.Value;
            }

            return sum;
        }

        /// <summary>
        /// Batchbill object to string.
        /// </summary>
        /// <returns>Current instance of BacthBill as string.</returns>
        public override string ToString()
        {
            return string.Format("Number of bills : {0}, \nTotal value of bills : {1}", this.Count, this.Total);
        }

        /// <summary>
        /// Get enumerator method.
        /// </summary>
        /// <returns>Current instance of BachtBill billList enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.billList.GetEnumerator();
        }
    }
}