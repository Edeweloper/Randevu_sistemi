using Microsoft.AspNetCore.Mvc;

namespace Randevus.Controllers
{
    public class EmptyPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
