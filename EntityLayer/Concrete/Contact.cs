﻿using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Creates { get; set; }= DateTime.UtcNow.AddHours(4);
    }
}
