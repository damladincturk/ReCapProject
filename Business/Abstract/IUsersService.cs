using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IUsersService
    {

        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int Id);
        IResult Add(Users users);

    }
}
