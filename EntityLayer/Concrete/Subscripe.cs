using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Subscripe : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }=DateTime.UtcNow.AddHours(4);
    }
}
