using System.ComponentModel.DataAnnotations;

namespace SonOfCodWebsite.ViewModels
{
    public class RegisterViewModels
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The confirmation password does not match the first password.")]
        public string ConfirmPassword { get; set; }
    }
}
