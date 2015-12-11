using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SignupSigninMVCExample.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Type something in Name Field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type something in Name Field"),
        DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Type something in Name Field"),
        DataType(DataType.Password),
        MinLength(8, ErrorMessage = "Password must be more than 8 characters"),
        MaxLength(20, ErrorMessage = "Password must be less than 20 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Type something in Name Field"),
        DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}