namespace DungeonsAndLizards
{
    using System;

    public abstract class Stats
    {
        private int value;

        protected Stats(int value)
        {
            this.Value = value;
        }

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.value = value;
                }
                else
                {
                    Console.WriteLine("ERROR: Health value is invalid!");
                }
            }
        }
    }
}
