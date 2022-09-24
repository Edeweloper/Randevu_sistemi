using System.ComponentModel.DataAnnotations;

namespace Randevus.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz..")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soy adınızı giriniz..")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz..")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz..")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz..")]
        public string Password { get; set; }
        
        public bool Is_Admin { get; set; }
     
        

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz..")]
        [Compare("Password", ErrorMessage = "Lütfen şifrenizi giriniz..")]
        public string ConfirmPassword { get; set; }

       
    }
}
