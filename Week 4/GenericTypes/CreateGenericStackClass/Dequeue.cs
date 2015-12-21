namespace CreateGenericStackClass
{
    using System.Collections.Generic;
    using System.Linq;

    public class Dequeue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public LinkedList<T> Clear()
        {
            this.list = new LinkedList<T>();
            return this.list;
        }

        public bool Contains(T item)
        {
            return this.list.Contains(item);
        }

        public LinkedList<T> RemoveFromFront()
        {
            this.list.RemoveFirst();
            return this.list;
        }

        public LinkedList<T> RemoveFromEnd()
        {
            this.list.RemoveLast();
            return this.list;
        }

        public LinkedList<T> AddToFront(T item)
        {
            this.list.AddFirst(item);
            return this.list;
        }

        public LinkedList<T> AddToEnd(T item)
        {
            this.list.AddLast(item);
            return this.list;
        }

        public T PeekFromFront()
        {
            return this.list.ToList()[this.list.ToList().Count - 1];
        }

        public T PeekFromEnd()
        {
            return this.list.ToList()[this.list.ToList().Count - 1];
        }
    }
}
