namespace GeometryFigures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Vector
    {
        private List<double> coordinates = new List<double>();
        public Vector(params int[] coor)
        {
            for (int i = 0; i < coor.Length; i++)
            {
                this.coordinates.Add(coor[i]);
            }
        }

        public Vector(Vector vect)
        {
            this.coordinates = vect.coordinates;
        }

        public double this[int index]
        {
            get
            {
                return coordinates[index];
            }

            set
            {
                coordinates[index] = value;
            }
        }

        public List<double> Coordinates
        {
            get { return this.coordinates; }
        }

        public int Dimensionality
        {
            get { return this.coordinates.Count; }
        }

        public double Lenght()
        {
            double len = 0;
            for (int i = 0; i < coordinates.Count; i++)
            {
                len += Math.Pow(coordinates[i], 2);
            }
            return Math.Sqrt(len);
        }

        public override string ToString()
        {
            StringBuilder dimensions = new StringBuilder();
            for (int i = 0; i < coordinates.Count; i++)
            {
                if (i != coordinates.Count - 1)
                {
                    dimensions.Append(coordinates[i].ToString() + ":");
                }
                else
                {
                    dimensions.Append(coordinates[i].ToString());
                }
            }
            return dimensions.ToString();
        }

        public static bool operator ==(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality && vect1.coordinates == vect2.coordinates)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality && vect1.coordinates == vect2.coordinates)
            {
                return false;
            }
            return true;
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
                hash = hash * 23 + coordinates.GetHashCode();
                hash = hash * 23 + Dimensionality.GetHashCode();
                return hash;
            }
        }

        public static Vector operator +(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality)
            {
                Vector result = vect1;
                for (int i = 0; i < vect1.coordinates.Count; i++)
                {
                    result[i] += vect2.coordinates[i];
                }

                return result;
            }

            throw new ArgumentException("Vectors must have same dimensions");
        }

        public static Vector operator -(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality)
            {
                Vector result = vect1;
                for (int i = 0; i < vect1.coordinates.Count; i++)
                {
                    result[i] -= vect2.coordinates[i];
                }

                return result;
            }

            throw new ArgumentException("Vectors must have same dimensions");
        }

        public static double operator *(Vector vect1, Vector vect2)
        {
            if (vect1.Dimensionality == vect2.Dimensionality)
            {
                Vector result = vect1;
                for (int i = 0; i < vect1.coordinates.Count; i++)
                {
                    result[i] *= vect2.coordinates[i];
                }

                return result.coordinates.Sum();
            }

            throw new ArgumentException("Vectors must have same dimensions");
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
    }
}
