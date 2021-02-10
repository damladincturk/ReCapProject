using System;
using Core.Entities;

namespace Entites.Concrete
{
    public class Car : IEntity
    {
       
            //: Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public long ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
