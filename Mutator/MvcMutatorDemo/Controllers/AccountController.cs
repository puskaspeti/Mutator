using System.Linq;
using System.Web.Mvc;
using HtmlMutator.MvcMutator;
using MvcMutatorDemo.Models;

namespace MvcMutatorDemo.Controllers
{
    public class AccountController : MutatorController
    {
        [AllowAnonymous]
        public ActionResult Register()
        {
            return CshtmlView("~/Views/Account/Register.cshtml", new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return CshtmlView("~/Views/Account/Register.cshtml", model);

            var user = new User { Email = model.Email, Password = model.Password, IsLoggedIn = true };
            TodoDbContext.Users.Add(user);

            if (returnUrl != null)
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return CshtmlView("~/Views/Account/Login.cshtml", new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return Login(returnUrl);
            }

            var result = TodoDbContext.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if(result != null)
            {
                if (returnUrl != null)
                    return Redirect(returnUrl);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return CshtmlView("~/Views/Account/Login.cshtml", model);
            }
        }
    }
}