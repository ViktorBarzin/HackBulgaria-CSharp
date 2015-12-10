using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericStackClass
{
    public class TotoGame
    {
        private List<object> genericList = new List<object>();

        public TotoGame(List<object> listOne)
        {
            this.GenericList = listOne;
        }
        public List<object> GenericList
        {
            get { return this.genericList; }
            set { this.genericList = value; }
        }



        public static bool operator ==(TotoGame obj1, TotoGame obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (object item in obj1.genericList)
            {
                if (!obj2.genericList.Contains(item))
                {
                    objOneEqualsObjTwo = false;
                    break;
                }
            }
            bool objTwoEqualsObjOne = true;
            foreach (object item in obj2.genericList)
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

        public static bool operator !=(TotoGame obj1, TotoGame obj2)
        {
            bool objOneEqualsObjTwo = true;
            foreach (object item in obj1.genericList)
            {
                if (!obj2.genericList.Contains(item))
                {
                    objOneEqualsObjTwo = false;
                }
            }
            bool objTwoEqualsObjOne = true;
            foreach (object item in obj2.genericList)
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
    }
}
