using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Models
{
    public class ProductDetail : Base
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Unit { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ManufactureCompanyId { get; set; }

        [Required]
        public string ManufactureDate { get; set; }

    }

}

