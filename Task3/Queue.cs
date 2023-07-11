using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Queue<T>
    {
        private List<T> items { set; get; }
        public Queue()
        {
        }

        public Queue(List<T> items)
        {
            this.items = items;
        }

        public bool IsEmpty()
        {
            return items.Count == 0 ? true : false;
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public int Size()
        {
            return items.Count();
        }
    }
}
