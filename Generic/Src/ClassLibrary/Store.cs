using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public T? GetById(int id)
        {
         
            return items.FirstOrDefault( x=> x.id == id);
        }
        public List<T> GetAll()
        {
            return items;
        }
    }
}
