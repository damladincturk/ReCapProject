using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalsDal : EfEntityRepositoryBase<Rentals, T_Context>, IRentalsDal
    {
        
    }
}
