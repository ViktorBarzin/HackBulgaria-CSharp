using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericStackClass
{
    public class LottoGame<T> : IComparable<T>
    {
        private List<T> genericList = new List<T>();
        public List<List<T>> userCombinations = new List<List<T>>();

        public LottoGame(List<T> listOne)
        {
            this.userCombinations.Add(listOne);
        }
        public List<T> GenericList
        {
            get { return this.GenericList; }
            set { this.GenericList = value; }
        }

        public void AddUserCombination(List<T> list)
        {
            if (!combinationExists(list))
            {
                // lotto lists
                this.userCombinations.Add(list);
            }
            else
            {
                Console.WriteLine("ERROR: Combination exists !");
            }
        }
        private bool combinationExists(List<T> l)
        {
            LottoGame<T> lot = new LottoGame<T>(l);
            if (this == lot)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (T item in obj1.genericList)
            {
                if (!obj2.genericList.Contains(item))
                {
                    objOneEqualsObjTwo = false;
                    break;
                }
            }
            bool objTwoEqualsObjOne = true;
            foreach (T item in obj2.genericList)
            {
                if (!obj1.genericList.Contains(item))
                {
                    objTwoEqualsObjOne = false;
                    break;
                }
            }
            if (objOneEqualsObjTwo && objTwoEqualsObjOne)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(LottoGame<T> obj1, LottoGame<T> obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (T item in obj1.genericList)
            {
                if (!obj2.genericList.Contains(item))
                {
                    objOneEqualsObjTwo = false;
                }
            }
            bool objTwoEqualsObjOne = true;
            foreach (T item in obj2.genericList)
            {
                if (!obj1.genericList.Contains(item))
                {
                    objTwoEqualsObjOne = false;
                }
            }
            if (objOneEqualsObjTwo && objTwoEqualsObjOne)
            {
                return false;
            }
            else
            {
                return true;
            }
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
                hash = hash * 23 + this.genericList.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
