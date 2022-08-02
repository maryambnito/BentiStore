﻿using MiMWebsite.Domains.Categories;
using MiMWebsite.Domains.Persons;
using System;

namespace MiMWebsite.Domains.Products
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Description{ get; set; }
        public string Image{ get; set; }
        public int CategoryId { get; set; }
        public Person Person { get; set; }
        public Category Category { get; set; }

    }
}
