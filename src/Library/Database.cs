using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{
    public class Database <T>
    {
        private ArrayList items = new ArrayList();

        public void Add(T item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }

        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.items)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}