using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=1997, DailyPrice=150, Description="kötü araba "},
            new Car{ Id=2, BrandId=2, ColorId=1, ModelYear=2020, DailyPrice=300, Description="mükemmel araba "},
            new Car{ Id=3, BrandId=2, ColorId=2, ModelYear=2017, DailyPrice=240, Description="güzel araba "},
            new Car{ Id=4, BrandId=1, ColorId=3, ModelYear=2008, DailyPrice=200, Description="idare araba "}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
           _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p=>p.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=>p.Id==car.Id);
            carToUpdate.BrandId = 2;
            carToUpdate.ColorId = 2;
            carToUpdate.Description = "güncelenen araba";
        }
    }
}
