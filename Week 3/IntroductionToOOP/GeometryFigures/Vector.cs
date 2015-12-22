namespace GeometryFigures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Vector
    {
        private readonly List<double> coordinates = new List<double>();

        public Vector(params int[] coor)
        {
            foreach (int t in coor)
            {
                this.coordinates.Add(t);
            }
        }

        public Vector(Vector vect)
        {
            this.coordinates = vect.coordinates;
        }

        public int Dimensionality
        {
            get { return this.coordinates.Count; }
        }

        public List<double> Coordinates
        {
            get { return this.coordinates; }
        }

        public double this[int index]
        {
            get
            {
                return this.coordinates[index];
            }

            set
            {
                this.coordinates[index] = value;
            }
        }

        public static bool operator ==(Vector vect1, Vector vect2)
        {
            if (vect2 != null && (vect1 != null && (vect1.Dimensionality == vect2.Dimensionality && vect1.coordinates == vect2.coordinates)))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Vector vect1, Vector vect2)
        {
            return vect2 != null && (vect1 != null && (vect1.Dimensionality != vect2.Dimensionality || vect1.coordinates != vect2.coordinates));
        }

        public static Vector operator +(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality != vect2.Dimensionality)
            {
                throw new ArgumentException("Vectors must have same dimensions");
            }

            Vector result = vect1;
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] += vect2.coordinates[i];
            }

            return result;
        }

        public static Vector operator -(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality != vect2.Dimensionality)
            {
                throw new ArgumentException("Vectors must have same dimensions");
            }

            Vector result = vect1;
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] -= vect2.coordinates[i];
            }

            return result;
        }

        public static double operator *(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality != vect2.Dimensionality)
            {
                throw new ArgumentException("Vectors must have same dimensions");
            }

            Vector result = vect1;
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] *= vect2.coordinates[i];
            }

            return result.coordinates.Sum();
        }

        public static Vector operator +(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] + scal;
            }

            return result;
        }

        public static Vector operator -(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] - scal;
            }

            return result;
        }

        public static Vector operator *(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] * scal;
            }

            return result;
        }

        public static Vector operator /(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] / scal;
            }

            return result;
        }

        public double Lenght()
        {
            return Math.Sqrt(this.coordinates.Sum(t => Math.Pow(t, 2)));
        }

        public override string ToString()
        {
            StringBuilder dimensions = new StringBuilder();
            for (int i = 0; i < this.coordinates.Count; i++)
            {
                if (i != this.coordinates.Count - 1)
                {
                    dimensions.Append(this.coordinates[i] + ":");
                }
                else
                {
                    dimensions.Append(this.coordinates[i]);
                }
            }

            return dimensions.ToString();
        }

        public override bool Equals(object obj)
        {
            if (this.coordinates == (obj as Vector).coordinates && this.Dimensionality == (obj as Vector).Dimensionality)
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
                hash = (hash * 23) + this.coordinates.GetHashCode();
                hash = (hash * 23) + this.Dimensionality.GetHashCode();
                return hash;
            }
        }
    }
}
