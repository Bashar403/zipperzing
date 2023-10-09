using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zipperzing.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Length { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public double AverageRating { get; set; }
    }
}
