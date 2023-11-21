using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }=DateTime.UtcNow.AddHours(4);
        public bool Status { get; set; }
    }
}
