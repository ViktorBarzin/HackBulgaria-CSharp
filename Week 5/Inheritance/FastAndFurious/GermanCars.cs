namespace FastAndFurious
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GermanCars : Car
    {
        private int _mileage;

        public GermanCars(int mileage)
        {
            this._mileage = mileage;
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
