namespace CreateGenericStackClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class <![CDATA[LottoGame]]> supporting generic types. 
    /// </summary>
    /// <typeparam name="T">Generic type.</typeparam>
    public class LottoGame<T> : IComparable<T>
    {
        /// <summary>
        /// Initializes a new instance of the LottoGame class.
        /// </summary>
        /// <param name="listOne">List of generic objects.</param>
        public LottoGame(List<T> listOne)
        {
            this.UserCombinations.Add(listOne);
        }

        /// <summary>
        /// Gets the user combination.
        /// </summary>
        /// <value>Setter is private.</value>
        public List<List<T>> UserCombinations { get; } = new List<List<T>>();

        /// <summary>
        /// Gets the generic list.
        /// </summary>
        /// <value>Setter is private.</value>
        public List<T> GenericList { get; } = new List<T>();

        /// <summary>
        /// Operator == for two LottoGame objects.
        /// </summary>
        /// <param name="obj1"><![CDATA[LottoGame]]> object one.</param>
        /// <param name="obj2"><![CDATA[LottoGame]]> object two.</param>
        /// <returns>True if both <![CDATA[LottoGame]]> objects are equal.</returns>
        public static bool operator ==(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = obj1 != null && obj1.GenericList.All(item => obj2 != null && obj2.GenericList.Contains(item));
            bool objTwoEqualsObjOne = obj2 != null && obj2.GenericList.All(item => obj1 != null && obj1.GenericList.Contains(item));
            return objOneEqualsObjTwo && objTwoEqualsObjOne;
        }

        /// <summary>
        /// Operator != for two LottoGame objects.
        /// </summary>
        /// <param name="obj1"><![CDATA[LottoGame]]> object one.</param>
        /// <param name="obj2"><![CDATA[LottoGame]]> object two.</param>
        /// <returns>True if both <![CDATA[LottoGame]]> objects are not equal.</returns>
        public static bool operator !=(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (T item in obj1.GenericList)
            {
                if (obj2 != null && !obj2.GenericList.Contains(item))
                {
                    objOneEqualsObjTwo = false;
                }
            }

            bool objTwoEqualsObjOne = true;
            if (!(obj2 != null))
            {
                return !objOneEqualsObjTwo;
            }

            foreach (T item in obj2.GenericList.Where(item => !obj1.GenericList.Contains(item)))
            {
                objTwoEqualsObjOne = false;
            }

            return !objOneEqualsObjTwo || !objTwoEqualsObjOne;
        }

        /// <summary>
        /// Overrides Equals() method for a LottoGame object and another object.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>True if both objects are equal. </returns>
        public override bool Equals(object obj)
        {
            if (this.Equals(obj as LottoGame<T>))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides GetHashCode() method for LottoGame object.
        /// </summary>
        /// <returns>Hash code for the <![CDATA[LottoGame]]> object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.GenericList.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Not implemented yet.
        /// </summary>
        /// <param name="other">Other generic object to compare with.</param>
        /// <returns>1 if current instance of the class is bigger than the object.0 if equal.-1 if smaller.</returns>
        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new user combination to the LottoGame object.
        /// </summary>
        /// <param name="list">Combination to add.</param>
        public void AddUserCombination(List<T> list)
        {
            if (!this.CombinationExists(list))
            {
                // lotto lists
                this.UserCombinations.Add(list);
            }
            else
            {
                Console.WriteLine("ERROR: Combination exists !");
            }
        }

        /// <summary>
        /// Checks if input combination already exists.
        /// </summary>
        /// <param name="l">Combination to check.</param>
        /// <returns>True if input combination equals LottoGame object's combination.</returns>
        private bool CombinationExists(List<T> l)
        {
            LottoGame<T> lot = new LottoGame<T>(l);
            return this == lot;
        }
    }
}
