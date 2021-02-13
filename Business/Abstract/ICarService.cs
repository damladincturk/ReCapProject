using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        List<CarDetailDTo> GetCarDetails();
        IDataResult<Car> GetById(int Id);
        IResult Add(Car car);
    }
}
