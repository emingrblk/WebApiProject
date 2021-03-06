﻿using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
