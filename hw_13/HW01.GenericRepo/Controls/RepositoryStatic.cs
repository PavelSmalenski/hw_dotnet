using HW01.GenericRepo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.GenericRepo.Controls
{
    class RepositoryStatic<T> : IRepository<T> where T : IRepositoryItem
    {
        private static List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Delete(Guid id)
        {
            _items.RemoveAll(item => item.Id.Equals(id));
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }

        public T GetById(Guid id)
        {
            return _items.Find(item => item.Id.Equals(id));
        }

        public void Update(T item)
        {
            T foundItem = GetById(item.Id);
            if (!(foundItem is null))
            {
                foundItem.Update(item);
            }
        }
    }
}
