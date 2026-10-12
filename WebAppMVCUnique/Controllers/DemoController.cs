using Microsoft.AspNetCore.Mvc;
using WebAppMVCUnique.Models;

namespace WebAppMVCUnique.Controllers
{
    public class DemoController : Controller
    {

        // code behind
        public IActionResult Test() {
            int x = 34;
            int y = 34;
            int z = x + y;
            TempData["res"] = z;

            return View(); // as an OP
        }


        public IActionResult Testing() { 
        return View();  
        }

        // Controller , View & Model


        [HttpGet] // on load
        public IActionResult Calci()
        {
            ViewBag.myres = TempData["res2"];
            ViewBag.sessionvalue = HttpContext.Session.GetString("key1");

            return View();  
        }

        [HttpPost]  // on Submit
        public IActionResult Calci(MyValues data)
        {
            // add of X+y
            int z = data.x + data.y;
            ViewBag.Result = z;
            return View();
        }


        // IactionResult --> Return Type
        // Returns a View
    }
}
