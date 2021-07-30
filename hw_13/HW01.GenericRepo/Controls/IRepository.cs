using HW01.GenericRepo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.GenericRepo.Controls
{
    /// <summary>
    /// Interface for CRUD Repository of Motorcycles
    /// </summary>
    interface IRepository<T> where T : IRepositoryItem
    {
        public void Add(T item);
        public List<T> GetAll();
        public T GetById(Guid id);
        public void Delete(Guid id);
        public void Update(T item);
    }
}
