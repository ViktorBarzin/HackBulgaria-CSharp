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
        /// Initializes a new instance of the <see cref="BatchBill"/> class.
        /// </summary>
        /// <param name="billList">List of Bills to add in the batchBill.</param>
        public BatchBill(List<Bill> billList)
        {
            this.Count = billList.Count;
            this.Total = this.Sum();
            this.BillValues = billList;
        }

        /// <summary>
        /// Gets a list of the bills in the batch bill class.
        /// </summary>
        /// <value>Bills are set in the constructor.</value>
        public List<Bill> BillValues { get; }

        /// <summary>
        /// Gets the count of the bills in the batch bill.
        /// </summary>
        /// <value>Count is set in the constructor.</value>
        public int Count { get; }

        /// <summary>
        /// Gets the total value of the bills in the batch bill.
        /// </summary>
        /// <value>Total is calculated in the constructor and cannot be set.</value>
        public int Total { get; }

        /// <summary>
        /// Gets an indexer for the current batch bill object.
        /// </summary>
        /// <param name="i">Indexer of the Bill class.</param>
        /// <returns>Indexer of the billList.</returns>
        public Bill this[int i]
        {
            get { return this.BillValues[i]; }
            set { this.BillValues[i] = value; }
        }
        
        /// <summary>
        /// <![CDATA[Batchbill]]> object to string.
        /// </summary>
        /// <returns>Current instance of <![CDATA[BacthBill]]> as string.</returns>
        public override string ToString()
        {
            return string.Format("Number of bills : {0}, \nTotal value of bills : {1}", this.Count, this.Total);
        }
        
        /// <summary>
        /// Get enumerator method.
        /// </summary>
        /// <returns>Current instance of BatchBill billList enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.BillValues.GetEnumerator();
        }

        /// <summary>
        /// Calculates the total of the bills objects values in the batch bill.
        /// </summary>
        /// <returns>The sum of the values of the Batch objects in current instance of BatchBill.</returns>
        private int Sum()
        {
            int sum = 0;
            foreach (var bill in this.BillValues)
            {
                sum += bill.Value;
            }

            return sum;
        }
    }
}