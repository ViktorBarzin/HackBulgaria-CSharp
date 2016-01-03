namespace Validation.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Validation class Stats.
    /// </summary>
    public static class Stats
    {
        /// <summary>
        /// Checks if value is positive.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if value is positive.</returns>
        public static bool IsValuePositive(int value)
        {
            return value > 0;
        }

        /// <summary>
        /// Checks if value is positive.
        /// </summary>
        /// <param name="values">Array of values to check.</param>
        /// <returns>True if values are all positive.</returns>
        public static bool IsValuePositive(int[] values)
        {
            return values.All(value => value >= 0);
        }
    }
}
