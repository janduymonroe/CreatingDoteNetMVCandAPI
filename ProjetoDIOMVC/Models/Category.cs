﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDIOMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Product> Procuct { get; set; }
    }
}
