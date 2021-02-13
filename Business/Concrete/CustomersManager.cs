using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersService   
    {
        ICustomersDal _customersDal;

        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult Add(Customers customers)
        {

            _customersDal.Add(customers);
            return new Result(true, "ürün eklendi");

        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new DataResult<List<Customers>>(_customersDal.GetAll(), true, "ürünler listelendi.");
        }

        public IDataResult<Customers> GetById(int customerId)
        {
            return new DataResult<Customers>(_customersDal.Get(p => p.UserId == customerId),true,"ürün listelendi");
        }
    }
}
