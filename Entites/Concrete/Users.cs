using System;
using Core.Entities;

namespace Entites.Concrete
{
    public class Users : IEntity
    {

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
      
    }
}
