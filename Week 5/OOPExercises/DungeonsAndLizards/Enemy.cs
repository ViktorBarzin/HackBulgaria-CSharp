namespace DungeonsAndLizards
{
    public class Enemy : Characters
    {
        public int Damage { get; protected set; }

        public Enemy(int health, int mana, int damage)
        {
            this.Health = new Health(health);
            this.Mana = new Mana(mana);
            this.Damage = damage;
        }
    }
}