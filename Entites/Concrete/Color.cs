using System;
using Core.Entities;


namespace Entites.Concrete
{
    public class Color : IEntity

    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
