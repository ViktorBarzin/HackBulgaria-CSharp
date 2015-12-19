namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Animals
    {
        public virtual string Greet()
        {
            return string.Format("Greet from animal");
        }

        public virtual void Move()
        {
            Console.WriteLine(" move");
        }

        public virtual void Eat()
        {
            Console.WriteLine(" eat");
        }

        public virtual void GiveBirth()
        {
            Console.WriteLine(" give birth");
        }
    }
}
