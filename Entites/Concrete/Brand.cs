using System;
using Entites.Abstract;

namespace Entites.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
