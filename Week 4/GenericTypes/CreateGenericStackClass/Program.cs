namespace CreateGenericStackClass
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            // List<List<object>> lottoGamesList = new List<List<object>>();
            List<object> listOne = new List<object>() { 3.20, 'v', 1, "as" };
            LottoGame<object> lottoGame = new LottoGame<object>(listOne);

            List<object> listTwo = new List<object>() { 3.20, 'v', "asa", 1 };
            lottoGame.AddUserCombination(listTwo);

            List<object> listThree = new List<object>() { 3.20, 'v', "asaa", 1 };
            lottoGame.AddUserCombination(listThree);

            // Console.WriteLine(String.Join(", ", lottoGame.userCombinations));

            // Console.Write("Enter a combination of values :");

            // List<object> listOne = new List<object>();
        }
    }
}
