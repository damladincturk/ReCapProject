using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<List<Customers>> GetAll();
        IResult Add(Customers customers);
        IDataResult<Customers> GetById(int customerId);
    }
}
