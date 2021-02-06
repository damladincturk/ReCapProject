using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (Car context=new Car()) {

                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(Car entity)
        {
            using (Car context = new Car())
            {

                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (Car context = new Car())
            {

                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (Car context = new Car())
            {

                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
