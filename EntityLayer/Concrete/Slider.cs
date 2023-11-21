﻿using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Slider : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
