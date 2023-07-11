using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class LinkedList<T>
    {
        public LinkedList()
        {
        }

        public LinkedList(List<T> items)
        {
            this.items = items;
        }

        private List<T> items {  get; set; }

        public int Add(T item)
        {
            items.Add(item);
            return items.Count;
        }

        public bool Remove(T item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }

            return false;
        }

        public bool Check(T item)
        {
            return items.Contains(item) ? true : false;
        }

        public int Index(T item)
        {
            if (Check(item))
            {
                return items.IndexOf(item);
            }

            return -1;
        }
    }
}
