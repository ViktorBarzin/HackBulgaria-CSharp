using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    public class AverageAggregator
    {
        public decimal Average { get; private set; }

        private void AddNumber(int number)
        {
            this.Average = (this.Average + number) / 2;
        }
    }
}
