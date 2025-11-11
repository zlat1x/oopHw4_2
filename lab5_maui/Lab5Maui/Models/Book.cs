using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5Maui.Models
{
    public class Book : Product
    {
        public int Pages { get; set; }
        public string Publisher { get; set; } = "";
        public List<string> Authors { get; set; } = new();

        public override string Kind => "Book";
    }
}