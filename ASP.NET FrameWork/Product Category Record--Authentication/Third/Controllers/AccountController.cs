using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Third.Models;
using Third.ViewModels;

namespace Third.Controllers
{
    public class AccountController : Controller
    {
        private StoreContext _context;

        public AccountController()
        {
            _context = new StoreContext();
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Register", user);
            }

            if (_context.User.Where(m => m.Email == user.Email).Any() || _context.User.Where(m => m.UserName == user.UserName).Any())
            {
                ModelState.AddModelError("Email", "User Name Or Email Is already exisit");
                return View("Register", user);
            }


            _context.User.Add(user);
            _context.SaveChanges();
            return Content("You Have Reg");

        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginFormViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", user);
            }

            var loginUser = _context.User.Where(m =>
                m.UserName == user.UserName && m.Password == user.Password && m.IsActive == true).FirstOrDefault();
            if (loginUser==null)
            {
                ModelState.AddModelError("UserName","User Name Or Password not valid");
                return View("Login",user);
            }
            else
            {
                Session["UserName"] = loginUser.UserName;//To Check if user loggedin
                return RedirectToAction("Index", "Home");
            }


            return View();
        }


        public ActionResult Logout()
        {
            


            Session.Abandon();//Remove All Sesion
            return RedirectToAction("Login");




        }
    }
}