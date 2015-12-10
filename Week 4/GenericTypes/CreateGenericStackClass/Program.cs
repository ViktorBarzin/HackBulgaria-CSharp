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
            List<object> listOne = new List<object>() { 3.20, 'v', 1, "as" };
            LottoGame<object> toto1 = new LottoGame<object>(listOne);

            List<object> listTwo = new List<object>() { 3.20, 'v', 1, "ass" };
            LottoGame<object> toto2 = new LottoGame<object>(listTwo);

            Console.WriteLine(toto1 == toto2);
        }
    }
}
