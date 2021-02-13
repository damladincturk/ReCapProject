using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, T_Context>, ICarDal
    {
        public List<CarDetailDTo> GetCarDetails()
        {
            using (T_Context context = new T_Context()) {

                var result = from p in context.Cars join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             select new CarDetailDTo {Id = p.Id, CarName= b.BrandId, ColorName=c.ColorId};

                return result.ToList();
            }
        }
    }
}
