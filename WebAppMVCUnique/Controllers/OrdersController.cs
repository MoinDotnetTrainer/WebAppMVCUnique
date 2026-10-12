using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCUnique.Controllers
{
    // [Route("[controller]/[action]")]
    // [Route("MYorders/[action]")]

    [Route("MyOrders")]


    public class OrdersController : Controller
    {
        [Route("AllOrders/{id}")]
        public IActionResult getOrders(int id)
        {
            TempData["id"] = id;
            return View();
        }
        [Route("NewOrders")]

        public IActionResult AddOrders()
        {
            return View();
        }
    }
}
