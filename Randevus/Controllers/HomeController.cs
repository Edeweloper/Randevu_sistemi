using DAL;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Randevus.Models;
using System.Diagnostics;

namespace Randevus.Controllers
{
    public class HomeController : Controller
    {
        context context = new context();
       
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var currentUserr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            
            if (currentUserr.Is_Admin == false)
            {
                string all = context.Randevu.Count()
              .ToString();

                string today = context.Randevu.Where(x => x.Start_Time > DateTime.Today).Count().ToString();
                string calls = context.Arama.Count().ToString();
                string[] list = { all, today, calls };
                ViewBag.numList = list;

            }
            else
            {
                string all = context.Randevu.Where(x => x.Ziyaret_EdilenKisiId ==currentUserr.Id).Count().ToString();
                string today = context.Randevu.Where(x => x.Start_Time > DateTime.Today && x.Ziyaret_EdilenKisiId == currentUserr.Id).Count().ToString();
                string calls = context.Arama.Where(x => x.ArananId == currentUserr.Id).Count().ToString();
                string[] list = { all, today, calls };
                ViewBag.numList = list;
               
            }

            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}