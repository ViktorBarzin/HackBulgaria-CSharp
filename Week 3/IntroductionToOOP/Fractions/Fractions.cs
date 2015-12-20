namespace Fractions
{
    using System;

    public class Fractions
    {
        private double _denominator;

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
                return this._denominator;
            }

            set
            {
                if (Math.Abs(value) < 0.00001)
                {
                    throw new ArgumentException("Denominator can't be 0 and your an idiot");
                }

                this._denominator = value;
            }
        }

        public static bool operator ==(Fractions obj, Fractions obj1)
        {
            return obj.Numerator == obj1.Numerator && obj._denominator == obj1._denominator;
        }

        public static bool operator !=(Fractions obj, Fractions obj1)
        {
            return !(obj.Numerator == obj1.Numerator) || !(obj._denominator == obj1._denominator);
        }

        public static double operator +(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1._denominator * obj2._denominator;
            obj1.Numerator *= obj2._denominator;
            obj2.Numerator *= obj1._denominator;
            return (obj1.Numerator + obj2.Numerator) / lcm;
        }

        public static double operator -(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1._denominator * obj2._denominator;
            obj1.Numerator *= obj2._denominator;
            obj2.Numerator *= obj1._denominator;
            return (obj1.Numerator - obj2.Numerator) / lcm;
        }

        public static double operator /(Fractions obj1, Fractions obj2)
        {
            return (obj1.Numerator / obj1._denominator) / (obj2.Numerator / obj2._denominator);
        }

        public static double operator *(Fractions obj1, Fractions obj2)
        {
            return (obj1.Numerator / obj1._denominator) * (obj2.Numerator / obj2._denominator);
        }

        public static double operator +(Fractions obj1, double num)
        {
            double fractionRes = obj1.Numerator / obj1._denominator;
            return fractionRes + num;
        }

        public static double operator -(Fractions obj1, double num)
        {
            return (obj1.Numerator / obj1._denominator) - num;
        }

        public static double operator *(Fractions obj1, double num)
        {
            return obj1.Numerator / obj1._denominator * num;
        }

        public static double operator /(Fractions obj1, double num)
        {
            return (obj1.Numerator / obj1._denominator) / num;
        }

        public override string ToString()
        {
            return string.Format(this.Numerator + "/" + this._denominator);
        }

        public override bool Equals(object obj)
        {
            if (this._denominator.Equals((obj as Fractions)._denominator) && this.Numerator.Equals((obj as Fractions).Numerator))
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
                hash = (hash * 23 )+ this._denominator.GetHashCode();
                return hash;
            }
        }
    }
}