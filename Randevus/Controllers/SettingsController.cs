using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Randevus.Models;

namespace Randevus.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        private readonly SignInManager<AppUser> _signInManager;


        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name =values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.Email =values.Email;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            
            user.Name = p.Name;
            user.Surname = p.SurName;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("","Home");   
            }
            else
            {
                //hata mesajları
            }
            return View();
        }
        public async Task<IActionResult> DeleteRandevu()
        {
            var values =await  _userManager.FindByNameAsync(User.Identity.Name);
            values.Is_Deleted = false;
            var result = await _userManager.UpdateAsync(values);
            await _signInManager.SignOutAsync();
            return RedirectToAction("", "Login");
        }
    }
}
