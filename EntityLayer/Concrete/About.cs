﻿using CoreLayer.Entity;
using System;


namespace EntityLayer.Concrete
{
    public class About : IEntity
    {
        public int Id { get;set; }
        public string Descriptsion { get; set; }
    }
}
