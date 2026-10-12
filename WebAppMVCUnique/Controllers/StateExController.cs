using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace WebAppMVCUnique.Controllers
{
    public class Std
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class StateExController : Controller
    {
        public IActionResult Page1()
        {
            ViewBag.vb = "Data from View bag";
            ViewBag.vb1 = 234;

            IList<Std> list = new List<Std>() {
            new Std{ Id=1,Name="xyz",Email="xyz@yahoo.com"},
            new Std{ Id=2,Name="abc",Email="abc@yahoo.com"},
            new Std{ Id=3,Name="pqr",Email="pqr@yahoo.com"},

            };

            ViewBag.data = list;
            ViewData["data1"] = list;
            //storing the data
            //retriv in UI , Action
            ViewBag.res = "Some data from viewbag";
            ViewData["res1"] = "Some data from view data";
            TempData["res2"] = "data from tempdata";
            //  return RedirectToAction("Calci","Demo");// from 1 to 2 only
            // return RedirectToAction("Page2");


            HttpContext.Session.SetString("key1", "Data from session");
            return RedirectToAction("page2");
        }
        public IActionResult Page2()
        {
            ViewBag.mydata = TempData["res2"];

            ViewBag.sessionvalue = HttpContext.Session.GetString("key1");
            TempData.Keep("res2");
            return View(); // destination 
        }
        public IActionResult Page3()
        {
            ViewBag.sessionvalue = HttpContext.Session.GetString("key1");
            return View();
        }
    }
}
