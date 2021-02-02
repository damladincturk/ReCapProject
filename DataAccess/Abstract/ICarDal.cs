using System;
using System.Collections.Generic;
using Entites.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // GetById, GetAll, Add, Update, Delete

        List<Car> GetById(int Id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
