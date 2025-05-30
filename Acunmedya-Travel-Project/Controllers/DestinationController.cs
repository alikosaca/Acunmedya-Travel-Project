using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acunmedya_Travel_Project.Entities;
using Acunmedya_Travel_Project.Concrete;
using System.Data.Entity;

namespace Acunmedya_Travel_Project.Controllers
{
    [Authorize]
    public class DestinationController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        public ActionResult Index()
        {
            //var destinations = _context.Destinations.Include(d=>d.category).ToList();
            var destinations = _context.Destinations.Include("category").ToList();

            return View(destinations);
        }

        public ActionResult AddDestination()
        {
            //var categories = _context.Categories
            //    .Select(c => new { c.CategoryName })
            //    .ToList();
            //ViewBag.CategoryList = categories;
            //return View();

            // Kategori listesini ViewBag'e ekleyelim
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryID", "CategoryName");

            // Destination modeli için boş bir model dönelim (tüm listesini değil)
            return View(new Destination());
        }
        [HttpPost]
        public ActionResult AddDestination(Destination _destination)
        {
            _destination.sold_ticket = 0;
            _context.Destinations.Add(_destination);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteDestination(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateDestination(int id)
        {
            var destination = _context.Destinations.Find(id);
            if (destination == null)
            {
                return HttpNotFound();
            }

            // Bu satırı ekleyin:
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryID", "CategoryName", destination.category_id);
            
            return View(destination);
        }
        [HttpPost]
        public ActionResult UpdateDestination(Destination _destination)
        {
            var value = _context.Destinations.Find(_destination.destination_id);
            //ViewBag.CategoryList = new SelectList(categories, "CategoryID", "CategoryName", destination.category.CategoryID);

            value.title = _destination.title;
            value.price = _destination.price;
            value.category_id = _destination.category_id;
            value.description = _destination.description;
            value.image_url = _destination.image_url;
            value.days_trip = _destination.days_trip;
            value.total_tickets = _destination.total_tickets;
            value.sold_ticket = _destination.sold_ticket;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}