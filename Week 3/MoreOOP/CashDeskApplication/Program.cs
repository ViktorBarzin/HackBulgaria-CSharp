namespace CashDeskApplication
{
    using System;
    using System.Collections.Generic;
    using CashDesk;

    /// <summary>
    /// CashDesk Application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks if user input is longer than 2 words.
        /// </summary>
        /// <param name="strin">Input to check.</param>
        /// <returns>True if input is longer than 2.</returns>
        public static bool IsInputLenghtLongerThan2(string[] strin)
        {
            if (strin.Length < 2)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            CashDesk obj = new CashDesk();
            while (true)
            {
                // Split input command
                string wholeCommand = Console.ReadLine();
                if (wholeCommand == null)
                {
                    continue;
                }

                string[] command = wholeCommand.Split(' ');
                switch (command[0])
                {
                    case "takebill":
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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
                        if (IsInputLenghtLongerThan2(command))
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

    // TODO: give change and buy stuff
}
