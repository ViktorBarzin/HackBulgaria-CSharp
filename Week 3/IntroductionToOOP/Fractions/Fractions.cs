namespace Fractions
{
    using System;

    /// <summary>
    /// Fractions Class.
    /// </summary>
    public class Fractions
    {
        /// <summary>
        /// Fraction denominator.
        /// </summary>
        private double denominator;

        /// <summary>
        /// Fraction numerator.
        /// </summary>
        private double numerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fractions"/> class.
        /// </summary>
        /// <param name="num">Integer to place a numerator.</param>
        /// <param name="denom">Integer to place as denominator.</param>
        public Fractions(int num, int denom)
        {
            this.numerator = num;
            this.Denominator = denom;
        }

        /// <summary>
        /// Gets or sets Denominator property.
        /// </summary>
        /// <value>Value must not be equal to 0.</value>
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
                    throw new ArgumentException("Denominator can't be 0");
                }

                this.denominator = value;
            }
        }

        /// <summary>
        /// Operator == for two objects of type Fraction.
        /// </summary>
        /// <param name="obj">Fraction object one.</param>
        /// <param name="obj1">Fraction object two.</param>
        /// <returns>True if both fractions are equal.</returns>
        public static bool operator ==(Fractions obj, Fractions obj1)
        {
            return obj1 != null && (obj != null && (Math.Abs(obj.numerator - obj1.numerator) < 0.001 && Math.Abs(obj.denominator - obj1.denominator) < 0.001));
        }

        /// <summary>
        /// Operator != for two objects of type Fraction.
        /// </summary>
        /// <param name="obj">Fraction object one.</param>
        /// <param name="obj1">Fraction object two.</param>
        /// <returns>True if both fractions are not equal.</returns>
        public static bool operator !=(Fractions obj, Fractions obj1)
        {
            return obj != null && (obj1 != null && (Math.Abs(obj.numerator - obj1.numerator) > 0.001 || Math.Abs(obj.denominator - obj1.denominator) > 0.001));
        }

        /// <summary>
        /// Operator + for two objects of type Fraction.
        /// </summary>
        /// <param name="obj1">Fraction object one.</param>
        /// <param name="obj2">Fraction object two.</param>
        /// <returns>The sum of the two fractions.</returns>
        public static double operator +(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.numerator *= obj2.denominator;
            obj2.numerator *= obj1.denominator;
            return (obj1.numerator + obj2.numerator) / lcm;
        }

        /// <summary>
        /// Operator - for two objects of type Fraction.
        /// </summary>
        /// <param name="obj1">Fraction object one.</param>
        /// <param name="obj2">Fraction object two.</param>
        /// <returns>The difference between the two fractions.</returns>
        public static double operator -(Fractions obj1, Fractions obj2)
        {
            double lcm = obj1.denominator * obj2.denominator;
            obj1.numerator *= obj2.denominator;
            obj2.numerator *= obj1.denominator;
            return (obj1.numerator - obj2.numerator) / lcm;
        }

        /// <summary>
        /// Operator / for two objects of type Fraction.
        /// </summary>
        /// <param name="obj1">Fraction object one.</param>
        /// <param name="obj2">Fraction object two.</param>
        /// <returns>The division of the two fractions.</returns>
        public static double operator /(Fractions obj1, Fractions obj2)
        {
            return (obj1.numerator / obj1.denominator) / (obj2.numerator / obj2.denominator);
        }

        /// <summary>
        /// Operator * for two objects of type Fraction.
        /// </summary>
        /// <param name="obj1">Fraction object one.</param>
        /// <param name="obj2">Fraction object two.</param>
        /// <returns>The multiplication of the two fractions.</returns>
        public static double operator *(Fractions obj1, Fractions obj2)
        {
            return (obj1.numerator / obj1.denominator) * (obj2.numerator / obj2.denominator);
        }

        /// <summary>
        /// Operator + between a Fraction object and a double.
        /// </summary>
        /// <param name="obj1">Fraction object.</param>
        /// <param name="num">Double number.</param>
        /// <returns>The sum of the Fraction object and the double number.</returns>
        public static double operator +(Fractions obj1, double num)
        {
            double fractionRes = obj1.numerator / obj1.denominator;
            return fractionRes + num;
        }

        /// <summary>
        /// Operator - between a Fraction object and a double.
        /// </summary>
        /// <param name="obj1">Fraction object.</param>
        /// <param name="num">Double number.</param>
        /// <returns>The difference of the Fraction object and the double number.</returns>
        public static double operator -(Fractions obj1, double num)
        {
            return (obj1.numerator / obj1.denominator) - num;
        }

        /// <summary>
        /// Operator * between a Fraction object and a double.
        /// </summary>
        /// <param name="obj1">Fraction object.</param>
        /// <param name="num">Double number.</param>
        /// <returns>The multiplication of the Fraction object and the double number.</returns>
        public static double operator *(Fractions obj1, double num)
        {
            return obj1.numerator / obj1.denominator * num;
        }

        /// <summary>
        /// Operator / between a Fraction object and a double.
        /// </summary>
        /// <param name="obj1">Fraction object.</param>
        /// <param name="num">Double number.</param>
        /// <returns>The division of the Fraction object and the double number.</returns>
        public static double operator /(Fractions obj1, double num)
        {
            return (obj1.numerator / obj1.denominator) / num;
        }

        /// <summary>
        /// To string method for objects of type Fraction.
        /// </summary>
        /// <returns>Objects of type Fraction to string type.</returns>
        public override string ToString()
        {
            return string.Format(this.numerator + "/" + this.denominator);
        }

        /// <summary>
        /// Override Equals method for Fraction type.objects.
        /// </summary>
        /// <param name="obj">Object to compare with.</param>
        /// <returns>True if the two objects are equal.</returns>
        public override bool Equals(object obj)
        {
            if (this.denominator.Equals((obj as Fractions).denominator) && this.numerator.Equals((obj as Fractions).numerator))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Override GetHashCode method for Fraction type objects.
        /// </summary>
        /// <returns>Hash code of a Fraction type object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.numerator.GetHashCode();
                hash = (hash * 23) + this.denominator.GetHashCode();
                return hash;
            }
        }
    }
}