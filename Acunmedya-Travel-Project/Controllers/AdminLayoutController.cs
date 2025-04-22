using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acunmedya_Travel_Project.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHead()
        {
            return PartialView();
        }
        public ActionResult PartialNavbar()
        {
            return PartialView();
        }
        public ActionResult PartialSider()
        {
            return PartialView();
        }
        public ActionResult PartialFooter()
        {
            return PartialView();
        }
        public ActionResult PartialScript()
        {
            return PartialView();
        }
        //public ActionResult PartialNavbar()
        //{
        //    return PartialView();
        //}
        //public ActionResult PartialSider()
        //{
        //    return PartialView();
        //}
    }
}