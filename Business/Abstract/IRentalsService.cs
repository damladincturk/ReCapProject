using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IDataResult<List<Rentals>> GetAll();
        IResult Add(Rentals customers);
        IDataResult<Rentals> GetById(int ColorId);
    }
}
