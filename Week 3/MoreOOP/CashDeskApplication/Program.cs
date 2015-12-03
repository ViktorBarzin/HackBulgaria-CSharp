using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk;
namespace CashDeskApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill newBill1 = new Bill(5);
            Bill newBill2 = new Bill(10);
            Bill newBill3 = new Bill(5);
            //newBill1.ToString();
            //Console.WriteLine(newBill.Value);
            //Console.WriteLine((int)newBill);
            //Console.WriteLine(newBill1 == newBill3);
            List<Bill> billList = new List<Bill> { newBill1, newBill2, newBill3 };
            BatchBill Batch = new BatchBill(billList);
            //Console.WriteLine(Batch.Total);
            //Console.WriteLine(Batch.ToString());
            //foreach (var item in Batch)
            //{
            //    Console.WriteLine(item);
            //}

            //TODO : continue CashDEsk class
        }
    }
}
