namespace FastAndFurious
{
    public class GermanCars : Car
    {
        private int mileage;

        public GermanCars(int mileage)
        {
            this.mileage = mileage;
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
