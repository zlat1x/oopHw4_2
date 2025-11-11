using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5Maui.Models
{
    public class FoodProduct : Product
    {
        public DateTime ExpirationDate { get; set; }
        public decimal Quantity { get; set; }      
        public string Unit { get; set; } = "pcs"; 

        public override string Kind => "Food";
    }
}