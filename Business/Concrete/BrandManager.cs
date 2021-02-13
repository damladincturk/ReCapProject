using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length <= 2)
            {
                return new ErrorResult("min karaakter 2 olmalı");
            }
            _brandDal.Add(brand);
            return new Result(true, "ürün eklendi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(),true,"ürünler listelendi.");
        }

        public IDataResult<Brand> GetById(int BrandId)
        {
            return new DataResult<Brand>(_brandDal.Get(p=>p.BrandId==BrandId),true,"ddd");
        }
    }
}
