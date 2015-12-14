using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericStackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<object>> LottoGamesList = new List<List<object>>();

            List<object> listOne = new List<object>() { 3.20, 'v', 1, "as" };
            LottoGame<object> lottoGame = new LottoGame<object>(listOne);

            List<object> listTwo = new List<object>() { 3.20, 'v', "asa", 1 };
            lottoGame.AddUserCombination(listTwo);

            List<object> listThree = new List<object>() { 3.20, 'v', "asaa", 1 };
            lottoGame.AddUserCombination(listThree);

            //Console.WriteLine(String.Join(", ", lottoGame.userCombinations));


            //Console.Write("Enter a combination of values :");

            //List<object> listOne = new List<object>();

            //Console.Write("Enter the amount of cominations you want to add :");
            //int combinations = int.Parse(Console.ReadLine());
            //for (int i = 0; i < combinations; i++)
            //{
            //    Console.Write("Enter {0} more combinations : ", combinations - i);
            //    var input = Console.ReadLine();
            //    while (input != "next")
            //    {
            //        Console.WriteLine("Enter item (next for next combination) :");
            //        listOne.Add(input);
            //        input = Console.ReadLine();
            //    }
            //    LottoGamesList.Add(listOne);
            //    listOne.Clear();
            //}
        }
    }
}
