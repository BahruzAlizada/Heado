using CoreLayer.Entity;
using System;


namespace EntityLayer.Concrete
{
    public class SocialMedia : IEntity
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool Status { get; set; }
    }
}
