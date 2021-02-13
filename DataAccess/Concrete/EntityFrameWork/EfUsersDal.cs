using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfUsersDal : EfEntityRepositoryBase<Users, T_Context>, IUsersDal
    {
        
    }
}
