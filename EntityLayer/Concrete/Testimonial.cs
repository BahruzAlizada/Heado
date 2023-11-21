using CoreLayer.Entity;
using System;


namespace EntityLayer.Concrete
{
    public class Testimonial : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
