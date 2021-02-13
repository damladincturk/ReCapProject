using System;
using Core.DateAccess;
using Entites.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomersDal : IEntityRepository<Customers>
    {
    }
}
