namespace CreateGenericStackClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Dequeue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();
        public Dequeue()
        {

        }

        public LinkedList<T> Clear()
        {
            this.list = new LinkedList<T>();
            return list;
        }

        public bool Contains(T item)
        {
            if (list.Contains(item))
            {
                return true;
            }
            return false;
        }

        public LinkedList<T> RemoveFromFront()
        {
            list.RemoveFirst();
            return list;
        }

        public LinkedList<T> RemoveFromEnd()
        {
            list.RemoveLast();
            return list;
        }

        public LinkedList<T> AddToFront(T item)
        {
            list.AddFirst(item);
            return list;
        }

        public LinkedList<T> AddToEnd(T item)
        {
            list.AddLast(item);
            return list;
        }

        public T PeekFromFront()
        {
            return list.ToList()[list.ToList().Count - 1];
        }

        public T PeekFromEnd()
        {
            return list.ToList()[list.ToList().Count - 1];
        }
    }
}
