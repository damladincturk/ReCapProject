using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
            IDataResult<List<Color>> GetAll();
            IResult  Add(Color color);
            IDataResult<Color> GetById(int ColorId);
    }
}
