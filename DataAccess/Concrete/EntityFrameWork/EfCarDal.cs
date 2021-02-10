using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, T_Context>, ICarDal
    {
        public List<CarDetailDTo> GetCarDetails()
        {
            using (T_Context context = new T_Context()) {

                var result = from p in context.Cars join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             select new CarDetailDTo {Id = p.ProductId, CarName= b.BrandName, ColorName=c.ColorName};

                return result.ToList();
            }
        }
    }
}
