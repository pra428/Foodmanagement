using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Models
{
    public class User : Base
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]

        public string Username { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public int ManufactureId { get; set; }

    }
}

