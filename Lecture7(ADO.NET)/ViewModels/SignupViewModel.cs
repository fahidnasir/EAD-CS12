using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Email is Required"), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required"), DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
