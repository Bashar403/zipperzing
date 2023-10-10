using System;
using System.ComponentModel.DataAnnotations;

namespace zipperzing.Models
{
    public class Product
    {
        public int Id { get; set; }

        // Validation for Product Name
        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        // Validation for Product Price
        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10,000.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        // Validation for Product Length
        [Range(1, 1000, ErrorMessage = "Length must be between 1 and 1,000.")]
        public int Length { get; set; }

        // Validation for Product Material
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Material must be between 3 and 100 characters.")]
        [Required(ErrorMessage = "The Material field is required.")]
        public string Material { get; set; }

        // Validation for Product Color
        [StringLength(50)]
        public string Color { get; set; }

        // Validation for Product Type
        [StringLength(50)]
        [Required(ErrorMessage = "The Type field is required.")]
        public string Type { get; set; }

        // Validation for Product AverageRating
        [Range(0.0, 10.0, ErrorMessage = "Average Rating must be between 0.0 and 10.0.")]
        public double AverageRating { get; set; }
    }
}
