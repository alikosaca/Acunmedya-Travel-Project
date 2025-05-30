using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acunmedya_Travel_Project.Entities;
using Acunmedya_Travel_Project.Concrete;

namespace Acunmedya_Travel_Project.Controllers
{
    [Authorize]
    public class TestimonialController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        public ActionResult Index()
        {
            ViewBag.TotalTestimonial = _context.Testimonials.Count();
            var values = _context.Testimonials.ToList();
            return View(values);
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial _testimonial)
        {
            _context.Testimonials.Add(_testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial _testimonial)
        {
            var values = _context.Testimonials.Find(_testimonial.TestimonialID);
            values.Name = _testimonial.Name;
            values.Surname = _testimonial.Surname;
            values.ImageUrl = _testimonial.ImageUrl;
            values.Description = _testimonial.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}