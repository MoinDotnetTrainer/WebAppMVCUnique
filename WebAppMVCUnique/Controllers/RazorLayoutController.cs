using Microsoft.AspNetCore.Mvc;
using WebAppMVCUnique.Models;

namespace WebAppMVCUnique.Controllers
{
    public class RazorLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ValidateMyForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateMyForm(ValidateModel data)
        {
            
            if (ModelState.IsValid) // TF --> model is passed with data anoo
            {
                // we perform insert ops
            }
            return View();
        }

    }
}
