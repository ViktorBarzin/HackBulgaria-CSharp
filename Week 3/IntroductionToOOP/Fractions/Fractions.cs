using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fractions
    {
        private double denominator;
        private double numerator;

        public Fractions(int num, int denom)
        {
            Numerator = num;
            Denominator = denom;
        }
        public double Numerator
        {
            get { return numerator; }
            set { this.numerator = value; }
        }
        public double Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be 0 and your an idiot");
                }
                this.denominator = value;
            }
        }
        public override string ToString()
        {
            string res = numerator.ToString() + "/" + denominator.ToString();
            Console.WriteLine(res);
            return res;
        }

        public override bool Equals(object obj)
        {
            if (this.denominator.Equals((obj as Fractions).denominator) && this.numerator.Equals((obj as Fractions).numerator))
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Fractions obj, Fractions obj1)
        {
            if (obj.numerator == obj1.numerator && obj.denominator == obj1.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fractions obj, Fractions obj1)
        {
            if (obj.numerator == obj1.numerator && obj.denominator == obj1.denominator)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }
        public static double operator +(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.numerator *= obj2.denominator;
            obj2.numerator *= obj1.denominator;
            return (obj1.numerator + obj2.numerator) / lcm;            
        }
        public static double operator -(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.numerator *= obj2.denominator;
            obj2.numerator *= obj1.denominator;
            return (obj1.numerator - obj2.numerator) / lcm;
        }
        public static double operator /(Fractions obj1, Fractions obj2)
        {
            return (obj1.numerator / obj1.denominator) / (obj2.numerator / obj2.denominator);
        }
        public static double operator *(Fractions obj1, Fractions obj2)
        {
            return (obj1.numerator / obj1.denominator) * (obj2.numerator / obj2.denominator);
        }

        public static double operator +(Fractions obj1, double num)
        {
            double fractionRes = obj1.numerator / obj1.denominator;
            return fractionRes + num;
            
        }
        public static double operator -(Fractions obj1, double num)
        {
            return obj1.numerator / obj1.denominator - num;
        }
        public static double operator *(Fractions obj1, double num)
        {
            return obj1.numerator / obj1.denominator * num;
        }
        public static double operator /(Fractions obj1, double num)
        {
            return obj1.numerator / obj1.denominator / num;
        }
    }
}
