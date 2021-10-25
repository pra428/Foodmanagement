using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Models
{
   public class Bank : Base
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="Enter Name of Bank")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Enter Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }


    }
}
