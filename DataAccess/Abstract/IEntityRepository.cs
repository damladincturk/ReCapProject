using System;
using System.Collections.Generic;
using Entites.Abstract;
using Entites.Concrete;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // GetById, GetAll, Add, Update, Delete

        List<T> GetById(int Id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
