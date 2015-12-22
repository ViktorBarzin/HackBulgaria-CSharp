namespace CreateGenericStackClass
{
    using System;
    using System.Collections.Generic;

    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Peek()
        {
            // TODO : implement chaining
            try
            {
                Console.WriteLine(this.items[this.items.Count - 1]);
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine("Stack empty");
            }
        }

        public T Pop()
        {
            T pop = this.items[this.items.Count - 1];
            this.items.Remove(pop);
            return pop;
        }

        public Stack<T> Push(T item)
        {
            this.items.Add(item);
            return this;
        }

        public Stack<T> Clear()
        {
            this.items = new List<T>();
            return this;
        }

        public bool Contains(T item)
        {
            foreach (T toFind in this.items)
            {
                if (toFind.ToString() == item.ToString())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
