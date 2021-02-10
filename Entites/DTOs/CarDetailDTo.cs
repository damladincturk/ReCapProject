using System;
using Entities;
using Core.Entities;

namespace Entites.DTOs
{
    public class CarDetailDTo:IDTo
    {
        public int Id { get; set; }
        public int CarName { get; set; }
        public int ColorName { get; set; }
       
    }
}
