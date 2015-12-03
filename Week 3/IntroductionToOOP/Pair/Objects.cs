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
    }
}
