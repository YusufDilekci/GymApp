using System.ComponentModel.DataAnnotations;

namespace GymApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Mailinizi girinz")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
