using System;
using Core.Entities;

namespace Entites.Concrete
{
    public class Rentals : IEntity
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
