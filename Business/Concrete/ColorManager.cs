using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length <= 2)
            {
                return new ErrorResult("min karaakter 2 olmalı");
            }
            _colorDal.Add(color);
            return new Result(true, "ürün eklendi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new DataResult<List<Color>>(_colorDal.GetAll(),true,"ürünler listelendi.");
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return new DataResult<Color>(_colorDal.Get(p => p.ColorId == ColorId),true,"deede");
        }
    }
}
