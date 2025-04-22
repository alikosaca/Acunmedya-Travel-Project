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
            FormsAuthentication.SignOut(); //var olan bir kullanıcı varsa çıkış yap
            Session.Abandon(); //Session'u varsa sil
            //neden yapıyoruz çünkü Login sayafsına geldiyse veriler silinip baştan giriş yapmasını sağlamak için
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
            FormsAuthentication.SetAuthCookie(model.UserName, false); //Cookie oluştur, UserName atıyoruz. false -> tarayıcıdan çıkış yapıldığında Cookie silinsin

            Session["currentUser"] = model.UserName; //Viewbag gibi düşünebiliriz. Burada oluşturup istediğimiz sayafada kullanabiliriz. örn/kullanıcı adımız olursa bunu çağırıyoruz


            return RedirectToAction("Index", "Service"); //Service'in index'ine yönlendir
            //return View();
        }
    }
}