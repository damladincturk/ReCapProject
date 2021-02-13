using System;
using Core.Entities;

namespace Entites.Concrete
{
    public class Customers : IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
