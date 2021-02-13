using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {

        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals customers)
        {
            _rentalsDal.Add(customers);
            return new Result(true, "ürün eklendi"); throw new NotImplementedException();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new DataResult<List<Rentals>>(_rentalsDal.GetAll(), true, "ürünler listelendi.");
        }

        public IDataResult<Rentals> GetById(int ColorId)
        {
            return new DataResult<Rentals>(_rentalsDal.Get(p => p.Id == ColorId), true, "sss");
        }
    }
}
