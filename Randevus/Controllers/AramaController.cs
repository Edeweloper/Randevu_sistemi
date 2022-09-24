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

namespace Randevus.Controllers
{
    public class AramaController : Controller
    {
        context context =new context();
        AramaTipiManager aramaTipiManager = new AramaTipiManager(new EfAramaTipiDal());
        ArayanTipiManager arayanTipiManager = new ArayanTipiManager(new EfArayanTipiDal());
        AramaManager aramaManager = new AramaManager(new EfAramaDal());
     

        private readonly UserManager<AppUser> _userManager;

        public AramaController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var currentUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var values = aramaManager.TGetListByID(currentUser.Id, currentUser.Is_Admin);


            List<Arama> randevu = new List<Arama>();
            
            foreach (var item in values)
            {
               
                if (item.Is_deleted == false)
                {  
                        randevu.Add(item);

                }
            };
            return View(randevu);
        }
        [HttpGet]
        [Authorize(Roles = "Sekreter1,Sekreter2")]
        public IActionResult AddArama()
        {
           
            List<SelectListItem> values_arama = (from x in aramaTipiManager.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Arama_tipi,
                                                     Value = x.Arama_tipi_id.ToString()
                                                 }).ToList();
            
            List<SelectListItem> values_arayan = (from x in arayanTipiManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Arayan_tipi,
                                                      Value = x.Arayan_tipi_id.ToString()
                                                  }).ToList();
            var usersWithRoles = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            ViewBag.User = usersWithRoles;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            return View();
        }
        
            
            [HttpPost]
        public IActionResult AddArama(Arama p)
        {
            List<SelectListItem> values_arama = (from x in aramaTipiManager.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Arama_tipi,
                                                     Value = x.Arama_tipi_id.ToString()
                                                 }).ToList();

            List<SelectListItem> values_arayan = (from x in arayanTipiManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Arayan_tipi,
                                                      Value = x.Arayan_tipi_id.ToString()
                                                  }).ToList();
            var users = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            ViewBag.User = users;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            AramaValidator aramavalidator = new AramaValidator();
            ValidationResult result = aramavalidator.Validate(p);
            if (result.IsValid)
            {
                aramaManager.TInsert(p);
                return RedirectToAction("Index");
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
        public IActionResult DeleteArama(int id)
        {
            var value = aramaManager.TGetById(id);
            value.Is_deleted = true;
            aramaManager.TUpdate(value);
            return RedirectToAction("Index");
            
            
           
        }
        
        [HttpGet]
        public IActionResult UpdateArama(int id)
        {
            List<SelectListItem> values_arama = (from x in aramaTipiManager.TGetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Arama_tipi,
                                                     Value = x.Arama_tipi_id.ToString()
                                                 }).ToList();

            List<SelectListItem> values_arayan = (from x in arayanTipiManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Arayan_tipi,
                                                      Value = x.Arayan_tipi_id.ToString()
                                                  }).ToList();
            var usersWithRoles = (from user in context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,

                                  }).ToList();
            ViewBag.User = usersWithRoles;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            
            var value = aramaManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateArama(Arama p)
        {
            aramaManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
