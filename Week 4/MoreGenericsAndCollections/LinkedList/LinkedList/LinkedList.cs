using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T>
    {
        private class Node
        {
            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = Next;
            }
            public T Value { get; set; }
            public Node Next { get; set; }
        }
        private Node Head { get; set; }

        private class LinkedListIterator
        {
        }
            

        public LinkedList<T> Add(T value)
        {
            if (Head.Equals(null))
            {
                Head = new Node(value, null);
                return this;
            }

            Node next = Head;
            while (!next.Next.Equals(null))
            {
                next = next.Next;
            }

            Node nodeToAdd = next;
            return this;
        }

        public LinkedList<T> InsertAfter(T key, T value)
        {
            Node insert = Head;
            insert.Value = value;
            while (!insert.Equals(null) && !insert.Value.Equals(key))
            {
                insert = insert.Next;
            }
            if (insert != null)
                insert.Next = new Node(value, insert.Next);
            return this;
        }

        public LinkedList<T> InsertBefore(T key, T value)
        {
            if (Head.Equals(null))
            {
                Head = new Node(value,null);
            }

            Node prev = null;
            Node curr = Head;
            while (curr != null && !curr.Value.Equals(key))
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr != null)
            {
                prev.Next = new Node(value, curr);
            }
            return this;
        }

        public LinkedList<T> InsertAt(T index, T value)
        {
            throw new NotImplementedException();
            
        }

        public LinkedList<T> Remove(T value)
        {
            if (Head.Equals(null))
            {
                throw new ArgumentException("Head is null");
            }
            Node curr = Head;
            Node prev = null;
            while (curr != null && !curr.Value.Equals(value))
            {
                prev = curr;
                curr = curr.Next;
            }
            if (curr.Equals(null))
            {
                throw new ArgumentException("Cannot delete");
            }
            prev.Next = curr.Next;
            return this;
        }

        //public Iterator<T> iterator()
        //{
        //    return new LinkedListIterator();
        //}

        public LinkedList<T> Clear()
        {
            if (Head.Equals(null))
            {
                return this;
            }

            Node prev = null;
            Node curr = Head;
            while (curr != null && !curr.Value.Equals(null))
            {
                prev = curr;
                curr = curr.Next;
                prev.Next = null;
            }
            return this;
        }
    }
}
