using Microsoft.AspNetCore.Mvc;
using WebAppMVCUnique.Models;

namespace WebAppMVCUnique.Controllers
{
    public class AccountsController : Controller
    {
        // value will be initilized only at constr level
        public  Appdb _db;
        public AccountsController()
        {
            _db = new Appdb();
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]  // on submit
        public IActionResult AddUser(UsersModel data)
        {
            _db.Users.Add(data);
            _db.SaveChanges();
            // db using ef core
            return View();
        }
    }
}
