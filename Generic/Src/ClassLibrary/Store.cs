using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class Store<T>  where  T : IHasId
    {
        private Dictionary<int, T> items = new Dictionary<int, T>();
        public  void Add(T item)
        {
           if(items.TryAdd(item.Id, item) == false)
            {
                throw new Exception($"Item with id {item.Id} already exists");
            }
        }
        public  void Remove(T item)
        {
            items.Remove(item.Id);
        }
        public  T? GetById(int id)
        {
         
            return items.GetValueOrDefault(id);
        }
        public  List<T> GetAll()
        {
            return new List<T>(items.Values);
        }
    }
}
