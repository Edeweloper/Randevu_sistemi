﻿using System.ComponentModel.DataAnnotations;

namespace Randevus.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adınızı giriniz..")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz..")]
        public string Password { get; set; }
       

    }
}
