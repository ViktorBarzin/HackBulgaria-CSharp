namespace Fractions
{
    using System;

    public class Fractions
    {
        private double denominator;

        public Fractions(int num, int denom)
        {
            this.Numerator = num;
            this.Denominator = denom;
        }

        public double Numerator { get; set; }

        public double Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (Math.Abs(value) < 0.00001)
                {
                    throw new ArgumentException("Denominator can't be 0 and your an idiot");
                }

                this.denominator = value;
            }
        }

        public static bool operator ==(Fractions obj, Fractions obj1)
        {
            return obj1 != null && (obj != null && (Math.Abs(obj.Numerator - obj1.Numerator) < 0.001 && Math.Abs(obj.denominator - obj1.denominator) < 0.001));
        }

        public static bool operator !=(Fractions obj, Fractions obj1)
        {
            return obj != null && (obj1 != null && (Math.Abs(obj.Numerator - obj1.Numerator) > 0.001 || Math.Abs(obj.denominator - obj1.denominator) > 0.001));
        }

        public static double operator +(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.Numerator *= obj2.denominator;
            obj2.Numerator *= obj1.denominator;
            return (obj1.Numerator + obj2.Numerator) / lcm;
        }

        public static double operator -(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.Numerator *= obj2.denominator;
            obj2.Numerator *= obj1.denominator;
            return (obj1.Numerator - obj2.Numerator) / lcm;
        }

        public static double operator /(Fractions obj1, Fractions obj2)
        {
            return (obj1.Numerator / obj1.denominator) / (obj2.Numerator / obj2.denominator);
        }

        public static double operator *(Fractions obj1, Fractions obj2)
        {
            return (obj1.Numerator / obj1.denominator) * (obj2.Numerator / obj2.denominator);
        }

        public static double operator +(Fractions obj1, double num)
        {
            double fractionRes = obj1.Numerator / obj1.denominator;
            return fractionRes + num;
        }

        public static double operator -(Fractions obj1, double num)
        {
            return (obj1.Numerator / obj1.denominator) - num;
        }

        public static double operator *(Fractions obj1, double num)
        {
            return obj1.Numerator / obj1.denominator * num;
        }

        public static double operator /(Fractions obj1, double num)
        {
            return (obj1.Numerator / obj1.denominator) / num;
        }

        public override string ToString()
        {
            return string.Format(this.Numerator + "/" + this.denominator);
        }

        public override bool Equals(object obj)
        {
            if (this.denominator.Equals((obj as Fractions).denominator) && this.Numerator.Equals((obj as Fractions).Numerator))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.Numerator.GetHashCode();
                hash = (hash * 23) + this.denominator.GetHashCode();
                return hash;
            }
        }
    }
}