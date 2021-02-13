using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entites.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {

        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users users)
        {
            _usersDal.Add(users);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new DataResult<List<Users>>(_usersDal.GetAll(), true, "ürünler listelendi.");
        }

        public IDataResult<Users> GetById(int Id)
        {
            return new DataResult<Users>(_usersDal.Get(p => p.Id == Id),true, "ürünler listelendi.");
        }
    }
}
