using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stack<T>
    {
        public List<T> items { set; get; }

        public Stack(List<T> items)
        {
            this.items = items;
        }

        public Stack()
        {
        }

        public Boolean IsEmpty()
        {
            return items.Count == 0 ? true : false;
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            T item = items[items.Count-1];
            return item;
        }

        public int Size()
        {
            return (int)items.Count;
        }
    }
}
