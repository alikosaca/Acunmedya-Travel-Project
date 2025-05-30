using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acunmedya_Travel_Project.Entities;
using Acunmedya_Travel_Project.Concrete;
using Newtonsoft.Json.Linq;

namespace Acunmedya_Travel_Project.Controllers
{
    [Authorize]
    public class SponsorController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        // GET: Sponsor
        public ActionResult Index()
        {
            var values = _context.Sponsors.ToList();
            return View(values);
        }
        public ActionResult AddSponsors()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSponsors(Sponsor _sponsor)
        {
            _context.Sponsors.Add(_sponsor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSponsors(int id)
        {
            var values = _context.Sponsors.Find(id);
            _context.Sponsors.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSponsors(int id)
        {
            var values = _context.Sponsors.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSponsors(Sponsor _sponsor)
        {
            var values = _context.Sponsors.Find(_sponsor.SponsorID);
            values.ImageUrl = _sponsor.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}