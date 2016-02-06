namespace GeometryFigures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class Vector.
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Vector object's coordinates.
        /// </summary>
        private readonly List<double> coordinates = new List<double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector"/> class.
        /// </summary>
        /// <param name="coor">Array of coordinates the vector object has.</param>
        public Vector(params int[] coor)
        {
            foreach (int t in coor)
            {
                this.coordinates.Add(t);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector"/> class. Copy Constructor.
        /// </summary>
        /// <param name="vect">Vector object to copy.</param>
        public Vector(Vector vect)
        {
            this.coordinates = vect.coordinates;
        }

        /// <summary>
        /// Gets the dimensionality of the Vector object.
        /// </summary>
        public int Dimensionality
        {
            get { return this.coordinates.Count; }
        }

        /// <summary>
        /// Gets the coordinates of the Vector object.
        /// </summary>
        public List<double> Coordinates
        {
            get { return this.coordinates; }
        }

        /// <summary>
        /// Indexer for the Vector object.
        /// </summary>
        /// <param name="index">Integer Indexer.</param>
        /// <returns>Index for Vector's coordinates.</returns>
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

        /// <summary>
        /// Operator == for two Vector object.
        /// </summary>
        /// <param name="vect1">Vector object one.</param>
        /// <param name="vect2">Vector object two.</param>
        /// <returns>True if the two Vector objects are equal.</returns>
        public static bool operator ==(Vector vect1, Vector vect2)
        {
            if (vect2 != null && (vect1 != null && (vect1.Dimensionality == vect2.Dimensionality && vect1.coordinates == vect2.coordinates)))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Operator != for two Vector object.
        /// </summary>
        /// <param name="vect1">Vector object one.</param>
        /// <param name="vect2">Vector object two.</param>
        /// <returns>True if the two Vector objects are not equal.</returns>
        public static bool operator !=(Vector vect1, Vector vect2)
        {
            return vect2 != null && (vect1 != null && (vect1.Dimensionality != vect2.Dimensionality || vect1.coordinates != vect2.coordinates));
        }

        /// <summary>
        /// Operator + for two Vector object.
        /// </summary>
        /// <param name="vect1">Vector object one.</param>
        /// <param name="vect2">Vector object two.</param>
        /// <returns>The sum of two Vector objects.</returns>
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

        /// <summary>
        /// Operator - for two Vector object.
        /// </summary>
        /// <param name="vect1">Vector object one.</param>
        /// <param name="vect2">Vector object two.</param>
        /// <returns>The difference of two Vector objects.</returns>
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

        /// <summary>
        /// Operator * for two Vector object.
        /// </summary>
        /// <param name="vect1">Vector object one.</param>
        /// <param name="vect2">Vector object two.</param>
        /// <returns>The multiplication of two Vector objects.</returns>
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

        /// <summary>
        /// Operator + for a Vector object and a double.
        /// </summary>
        /// <param name="vect1">Vector object.</param>
        /// <param name="scal">double number.</param>
        /// <returns>The sum of the Vector object and the double.</returns>
        public static Vector operator +(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] + scal;
            }

            return result;
        }

        /// <summary>
        /// Operator - for a Vector object and a double.
        /// </summary>
        /// <param name="vect1">Vector object.</param>
        /// <param name="scal">double number.</param>
        /// <returns>The difference of the Vector object and the double.</returns>
        public static Vector operator -(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] - scal;
            }

            return result;
        }

        /// <summary>
        /// Operator * for a Vector object and a double.
        /// </summary>
        /// <param name="vect1">Vector object.</param>
        /// <param name="scal">double number.</param>
        /// <returns>The multiplication of the Vector object and the double.</returns>
        public static Vector operator *(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] * scal;
            }

            return result;
        }

        /// <summary>
        /// Operator / for a Vector object and a double.
        /// </summary>
        /// <param name="vect1">Vector object.</param>
        /// <param name="scal">double number.</param>
        /// <returns>The division of the Vector object and the double.</returns>
        public static Vector operator /(Vector vect1, double scal)
        {
            Vector result = new Vector();
            for (int i = 0; i < vect1.coordinates.Count; i++)
            {
                result[i] = vect1.coordinates[i] / scal;
            }

            return result;
        }

        /// <summary>
        /// Length of Vector object.
        /// </summary>
        /// <returns>The length of the Vector object.</returns>
        public double Length()
        {
            return Math.Sqrt(this.coordinates.Sum(t => Math.Pow(t, 2)));
        }

        /// <summary>
        /// Overrides ToString() method for Vector objects.
        /// </summary>
        /// <returns>The Vector object as String.</returns>
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

        /// <summary>
        /// Overrides Equals() method for Vector objects.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if the input object equals the Vector object</returns>
        public override bool Equals(object obj)
        {
            if (this.coordinates == (obj as Vector).coordinates && this.Dimensionality == (obj as Vector).Dimensionality)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides GetHasCode() method for Vector objects.
        /// </summary>
        /// <returns>Hash code of Vector object.</returns>
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
