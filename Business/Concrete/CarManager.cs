
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length<=2)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult( Messages.CarAdded);

        }

        public IDataResult<List<Car>> GetAll()
        {
            DateTime now = DateTime.Now;

            if (now.Hour == 22)
            {

                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);

            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new DataResult<Car>(_carDal.Get(p => p.Id == Id), true, "car getirildi.");
        }

        public List<CarDetailDTo> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
