namespace Animals
{
    public class Crocodile : Animals, ILandAnimals
    {
        public override string Greet()
        {
            return string.Format("krok krok");
        }
    }
}
