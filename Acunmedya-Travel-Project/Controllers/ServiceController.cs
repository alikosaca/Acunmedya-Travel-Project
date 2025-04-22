using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acunmedya_Travel_Project.Concrete;
using Acunmedya_Travel_Project.Entities;

namespace Acunmedya_Travel_Project.Controllers
{
    [Authorize]
    public class ServiceController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        // GET: Service
        public ActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddServices(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteServices(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = _context.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateServices(Service model)
        {
            var value = _context.Services.Find(model.ServiceID);
            value.Descreption = model.Descreption;
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;

            return RedirectToAction("Index");
        }
    }
}