using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Objects
    {
        private object key;
        private object value;

        public Objects(object key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public object Key
        {
            get
            {
                return this.key;
            }
        }
        public object Value
        {
            get
            {
                return this.value;
            }
        }

        public override string ToString()
        {
            string res = this.key + ":" + this.value;
            return res;
        }
        public override bool Equals(object obj)
        {
            if (this.value == (obj as Objects).value && this.key == (obj as Objects).key)
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
                hash = hash * 23 + this.key.GetHashCode();
                hash = hash * 23 + this.value.GetHashCode();
                return hash;
            }
        }
    }
}
