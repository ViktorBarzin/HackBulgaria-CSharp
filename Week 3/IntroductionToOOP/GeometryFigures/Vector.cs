namespace GeometryFigures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Vector
    {
        private readonly List<double> _coordinates = new List<double>();

        public Vector(params int[] coor)
        {
            foreach (int t in coor)
            {
                this._coordinates.Add(t);
            }
        }

        public Vector(Vector vect)
        {
            this._coordinates = vect._coordinates;
        }

        public int Dimensionality
        {
            get { return this._coordinates.Count; }
        }

        public List<double> Coordinates
        {
            get { return this._coordinates; }
        }

        public double this[int index]
        {
            get
            {
                return this._coordinates[index];
            }

            set
            {
                this._coordinates[index] = value;
            }
        }

        public static bool operator ==(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality && vect1._coordinates == vect2._coordinates)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Vector vect1, Vector vect2)
        {
            return !(vect1.Dimensionality == vect2.Dimensionality) || vect1._coordinates != vect2._coordinates;
        }

        public static Vector operator +(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality != vect2.Dimensionality)
            {
                throw new ArgumentException("Vectors must have same dimensions");
            }

            Vector result = vect1;
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] += vect2._coordinates[i];
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
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] -= vect2._coordinates[i];
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
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] *= vect2._coordinates[i];
            }

            return result._coordinates.Sum();
        }

        public static Vector operator +(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] = vect1._coordinates[i] + scal;
            }

            return result;
        }

        public static Vector operator -(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] = vect1._coordinates[i] - scal;
            }

            return result;
        }

        public static Vector operator *(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] = vect1._coordinates[i] * scal;
            }

            return result;
        }

        public static Vector operator /(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1._coordinates.Count; i++)
            {
                result[i] = vect1._coordinates[i] / scal;
            }

            return result;
        }

        public double Lenght()
        {
            return Math.Sqrt(this._coordinates.Sum(t => Math.Pow(t, 2)));
        }

        public override string ToString()
        {
            StringBuilder dimensions = new StringBuilder();
            for (int i = 0; i < this._coordinates.Count; i++)
            {
                if (i != this._coordinates.Count - 1)
                {
                    dimensions.Append(this._coordinates[i] + ":");
                }
                else
                {
                    dimensions.Append(this._coordinates[i]);
                }
            }

            return dimensions.ToString();
        }

        public override bool Equals(object obj)
        {
            if (this._coordinates == (obj as Vector)._coordinates && this.Dimensionality == (obj as Vector).Dimensionality)
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
                hash = (hash * 23) + this._coordinates.GetHashCode();
                hash = (hash * 23) + this.Dimensionality.GetHashCode();
                return hash;
            }
        }
    }
}
