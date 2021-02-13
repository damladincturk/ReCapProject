using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCustomersDal : EfEntityRepositoryBase<Customers, T_Context>,ICustomersDal
    {
       
    }
}
