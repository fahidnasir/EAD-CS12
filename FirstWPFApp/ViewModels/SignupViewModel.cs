using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPFApp.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Email is Required"), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required"), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
