namespace CreateGenericStackClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LottoGame<T> : IComparable<T>
    {
        public List<List<T>> UserCombinations { get; } = new List<List<T>>();

        public LottoGame(List<T> listOne)
        {
            this.UserCombinations.Add(listOne);
        }

        public List<T> GenericList { get; set; } = new List<T>();

        public static bool operator ==(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = obj1 != null && obj1.GenericList.All(item => obj2 != null && obj2.GenericList.Contains(item));
            bool objTwoEqualsObjOne = obj2 != null && obj2.GenericList.All(item => obj1 != null && obj1.GenericList.Contains(item));
            return objOneEqualsObjTwo && objTwoEqualsObjOne;
        }

        public static bool operator !=(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (T item in obj1.GenericList.Where(item => obj2 != null && !obj2.GenericList.Contains(item)))
            {
                objOneEqualsObjTwo = false;
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

        public override bool Equals(object obj)
        {
            if (this.Equals(obj as LottoGame<T>))
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
                hash = (hash * 23) + this.GenericList.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

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

        private bool CombinationExists(List<T> l)
        {
            LottoGame<T> lot = new LottoGame<T>(l);
            return this == lot;
        }
    }
}
