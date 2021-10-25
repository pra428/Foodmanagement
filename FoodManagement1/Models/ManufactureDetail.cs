using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Models
{
    public class ManufactureDetail : Base
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public int CompanyRegistrationNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int UserId { get; set; }
    }

}

