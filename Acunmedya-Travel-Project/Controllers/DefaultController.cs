using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acunmedya_Travel_Project.Concrete;
using Acunmedya_Travel_Project.Entities;

namespace Acunmedya_Travel_Project.Controllers
{
    public class DefaultController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
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
        public ActionResult PartialHome()
        {
            return PartialView();
        }
        public ActionResult PartialService()
        {
            var values = _context.Services.ToList();
            return PartialView(values);
        }
        public ActionResult PartialBooking()
        {
            var values = _context.Destinations.Include("category").ToList();
            return PartialView(values);
        }
        public ActionResult PartialHelper()
        {
            return PartialView();
        }
        public ActionResult PartialTestimonial()
        {
            var values = _context.Testimonials.ToList();
            return PartialView(values);
        }
        public ActionResult PartialSponsors()
        {
            var values = _context.Sponsors.ToList();
            return PartialView(values);
        }
        public ActionResult PartialNewsletter()
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
    }
}