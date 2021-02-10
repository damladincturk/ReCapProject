using System;
using System.Collections.Generic;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailDTo> GetCarDetails();
    }
}
