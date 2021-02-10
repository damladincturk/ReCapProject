using System;
using System.Collections.Generic;
using Core.DateAccess;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Abstract 
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDTo> GetCarDetails();
    }
}
