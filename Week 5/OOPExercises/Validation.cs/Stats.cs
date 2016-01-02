namespace Validation.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Stats
    {
        public static bool IsValuePositive(int value)
        {
            return value > 0;
        }

        public static bool IsValuePositive(int[] values)
        {
            return values.All(value => value >= 0);
        }
    }
}
