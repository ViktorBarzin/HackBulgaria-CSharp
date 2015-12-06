using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk;
namespace CashDesk
{
    class Program
    {
        public static bool IsInputLenghtLessThan2(string[] strin)
        {
            if (strin.Length < 2)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            CashDesk obj = new CashDesk();
            while (true)
            {
                string wholeCommand = Console.ReadLine();
                string[] command = wholeCommand.Split(' ');
                switch (command[0])
                {
                    case "takebill":
                        if (IsInputLenghtLessThan2(command))
                        {
                            if (command.Length < 3)
                            {
                                obj.TakeMoney(new Bill(int.Parse(command[1])));
                            }
                            else
                            {
                                Console.WriteLine("ERROR: takebill command takes only 1 parameter");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input Command lenght too short");
                        }
                        break;
                    case "takebatch":
                        if (IsInputLenghtLessThan2(command))
                        {
                            List<Bill> billList = new List<Bill>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                billList.Add(new Bill(int.Parse(command[i])));
                            }
                            BatchBill batch = new BatchBill(billList);
                            obj.TakeMoney(batch);
                            
                        }
                        break;

                    case "takecoin":
                        if (IsInputLenghtLessThan2(command))
                        {
                            if (command.Length < 3)
                            {
                                obj.TakeMoney(new Coin(int.Parse(command[1])));
                                
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Takecoin command takes only 1 parameter !");
                            }
                        }
                        break;
                    case "takebatchcoin":
                        if (IsInputLenghtLessThan2(command))
                        {
                            List<Coin> coinlist = new List<Coin>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                coinlist.Add(new Coin(int.Parse(command[i])));
                            }
                            BatchCoin coinBatch = new BatchCoin(coinlist);
                            obj.TakeMoney(coinBatch);
                            Console.WriteLine("SUCCESS: added new batch of coins !");
                        }
                        break;
                    case "removebill":
                        if (IsInputLenghtLessThan2(command))
                        {
                            if (command.Length < 3)
                            {
                                obj.RemoveMoney(new Bill(int.Parse(command[1])));

                            }
                            else
                            {
                                Console.WriteLine("ERROR: removebill command takes only 1 parameter !");
                            }
                        }
                        break;
                    case "removebatch":
                        if (IsInputLenghtLessThan2(command))
                        {
                            List<Bill> billList = new List<Bill>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                billList.Add(new Bill(int.Parse(command[i])));
                            }
                            BatchBill batch = new BatchBill(billList);
                            obj.RemoveMoney(batch);
                        }
                        break;
                    case "removeallbills":
                        if (command.Length < 2)
                        {
                            obj.RemoveAllBills();
                            Console.WriteLine("SUCCES: you have removed all coins !");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: removeallbills command takes no parameters !");
                        }
                        break;
                    case "removecoin":
                        if (IsInputLenghtLessThan2(command))
                        {
                            if (command.Length < 3)
                            {
                                obj.RemoveMoney(new Coin(int.Parse(command[1])));

                            }
                            else
                            {
                                Console.WriteLine("ERROR: removecoin command takes only 1 parameter !");
                            }
                        }
                        break;
                    case "removebatchcoin":
                        if (IsInputLenghtLessThan2(command))
                        {
                            List<Coin> coinList = new List<Coin>();
                            for (int i = 1; i < command.Length; i++)
                            {
                                coinList.Add(new Coin(int.Parse(command[i])));
                            }
                            BatchCoin batch = new BatchCoin(coinList);
                            obj.RemoveMoney(batch);
                        }
                        break;
                    case "removeallcoins":
                        if (command.Length < 2)
                        {
                            obj.RemoveAllCoins();
                            Console.WriteLine("SUCCES: you have removed all coins !");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: removeallcoins command takes no parameters !");
                        }
                        break;






                    case "total":
                        if (command.Length < 2)
                        {
                            Console.WriteLine(obj.Total());
                        }
                        else
                        {
                            Console.WriteLine("ERROR: total command takes no parameters !");
                        }
                        break;
                    case "inspect":
                        if (command.Length < 2)
                        {
                            obj.Inspect();
                        }
                        else
                        {
                            Console.WriteLine("ERROR: inspect commands takes no parameters !");
                        }
                        break;
                    case "exit":
                        if (command.Length < 2)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("did you mean \"exit\" ?");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown Command " + command);
                        break;
                }
            }
        }
    }
    //TODO: give change
}
