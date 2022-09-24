 using BAL.Concrete;
using BAL.FluentValidation;
using DAL;
using DAL.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Randevus.Models;
using System.Diagnostics;

namespace Randevus.Controllers
{
   
    public class RandevularController : Controller
    {
        Randevu_durumuManager randevudurumuManager = new Randevu_durumuManager(new EfRandevu_durumuDal());
        context context = new context();
        RandevularManager randevularManager = new RandevularManager(new EfRandevularDal());
       

        private readonly UserManager<AppUser> _userManager;

        public RandevularController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var currentUser = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var values = randevularManager.TGetListByID(currentUser.Id, currentUser.Is_Admin);
            List<Randevular> randevu = new List<Randevular>();
            
            
            foreach (var item in values) {
                
              
                if (item.Is_deleted == false)
                {
                        randevu.Add(item);
                }
               
            }; 
            return View(randevu);
        }
        
        [HttpGet]
        [Authorize(Roles = "Sekreter1,Sekreter2")]
        


        public IActionResult AddRandevu()
        {
            List<SelectListItem> values_randur = (from x in randevudurumuManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Randevu_Durumu,
                                                      Value = x.RandevuID.ToString()
                                                  }).ToList();
            var users = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            
            ViewBag.User = users;
            ViewBag.randur = values_randur;
            return View();
        }
        [HttpPost]
        public IActionResult AddRandevu(Randevular p)
        {
            List<SelectListItem> values_randur = (from x in randevudurumuManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Randevu_Durumu,
                                                      Value = x.RandevuID.ToString()
                                                  }).ToList();
            var users = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            ViewBag.User = users;
            ViewBag.randur = values_randur;
            RandevularValidator aramavalidator = new RandevularValidator();
            ValidationResult result = aramavalidator.Validate(p);
            if (result.IsValid)
            {
             randevularManager.TInsert(p);
                return RedirectToAction("", "Home");
            }
            else
            {

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
        
        public IActionResult DeleteRandevu( int id)
        {
            var value = randevularManager.TGetById(id);
            value.Is_deleted = true;
            randevularManager.TUpdate(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateRandevu(int id)
        {
            List<SelectListItem> values_randur = (from x in randevudurumuManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Randevu_Durumu,
                                                      Value = x.RandevuID.ToString()
                                                  }).ToList();
            var usersWithRoles = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            ViewBag.User = usersWithRoles;
            ViewBag.randur = values_randur;
            var value = randevularManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateRandevu(Randevular p)
        {
            randevularManager.TUpdate(p);
            return RedirectToAction("Index"); 
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
        public IActionResult Datetime()
        {

            return View();
        }



    }
}
