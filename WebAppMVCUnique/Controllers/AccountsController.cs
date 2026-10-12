using Microsoft.AspNetCore.Mvc;
using WebAppMVCUnique.Models;

namespace WebAppMVCUnique.Controllers
{
    public class AccountsController : Controller
    {
        // value will be initilized only at constr level
        public Appdb _db;
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
            int res = _db.SaveChanges();  // no of rows effcted
            if (res > 0)
            {
                return RedirectToAction("GetUser");
            }
            // db using ef core
            return View();
        }


        [HttpGet]  // Onload
        public IActionResult GetUser()
        {
            IEnumerable<UsersModel> data = _db.Users.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult EditUser(int UserID)
        {
            var res = _db.Users.FirstOrDefault(x => x.UserID == UserID);
            return View(res);
        }

        [HttpPost]
        public IActionResult EditUser(UsersModel data)
        {
            _db.Users.Update(data);
            int res = _db.SaveChanges();  // no of rows effcted
            if (res > 0)
            {
                return RedirectToAction("GetUser");
            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteUser(int UserID)
        {
            var res = _db.Users.Find(UserID);
            return View(res);
        }

        [HttpPost, ActionName("DeleteUser")]
        public IActionResult DeleteConfirm(int UserID)
        {
            var res = _db.Users.Find(UserID);

            if (res != null)
            {
                _db.Users.Remove(res);
                int result = _db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("GetUser");
                }

            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            //  var res = _db.Users.Any(x=>x.Email==data.Email && x.Password==data.Password);

            

            if (data.Email == "xyz@yahoo.com" && data.Password == "123")
            {
                HttpContext.Session.SetString("LoggedIn", "yes");
                // is null
                return RedirectToAction("Homepage");
            }
            return View();
        }
        public IActionResult Homepage()
        {
            if (HttpContext.Session.GetString("LoggedIn") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
