using Acunmedya_Travel_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Acunmedya_Travel_Project.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin model)
        {
            var values = _context.Admins.FirstOrDefault(x=>x.UserName == model.UserName && x.Password == model.Password);
            if (values == null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı ve şifre hatalı");
                return View(model);
            }
            FormsAuthentication.SetAuthCookie(model.UserName, false); 

            Session["currentUser"] = model.UserName; 

            return RedirectToAction("Index", "Service");
        }
    }
}