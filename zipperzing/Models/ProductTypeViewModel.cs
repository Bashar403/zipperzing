using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace zipperzing.Models
{
    public class ProductTypeViewModel
    {
        public List<Product> products { get; set; }
        public SelectList Type { get; set; }
        public string ProductType { get; set; } //which contains the selected Types.
        public string SearchString { get; set; }
    }
}
