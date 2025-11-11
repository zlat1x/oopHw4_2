using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5Maui.Models
{
    public class Product
    {
        public decimal Price { get; set; }
        public string CountryOfOrigin { get; set; } = "";
        public string Name { get; set; } = "";
        public DateTime PackingDate { get; set; }
        public string Description { get; set; } = "";

        public virtual string Kind => "Product";
    }
}