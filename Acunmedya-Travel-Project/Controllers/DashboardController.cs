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
    public class DashboardController : Controller
    {
        Acunmedya_Travel_Project.Concrete.Context _context = new Acunmedya_Travel_Project.Concrete.Context();
        public ActionResult Index()
        {
            ViewBag.TotalTours = _context.Destinations.Count(); // Toplam tur sayısı
            ViewBag.TotalSponsors = _context.Sponsors.Count(); //sponsor sayısı
            ViewBag.TotalTestimonial = _context.Testimonials.Count(); //referans sayısı
            ViewBag.LastestBookings = _context.Destinations.OrderByDescending(d => d.destination_id).Take(5).ToList(); //son beş kayıt
            ViewBag.TotalAdmin = _context.Admins.Count(); //Admin sayısı
            ViewBag.TotalEuropeTur = _context.Destinations.Count(d => d.category_id == 1);
            ViewBag.TotalAsiaTur = _context.Destinations.Count(d => d.category_id == 2);
            ViewBag.TotalAmericaTur = _context.Destinations.Count(d => d.category_id == 3);
            ViewBag.TotalAfricaTur = _context.Destinations.Count(d => d.category_id == 4);
            ViewBag.TotalAustrliaTur = _context.Destinations.Count(d => d.category_id == 5);
            decimal totalPrice = _context.Destinations.Sum(d => d.price);
            ViewBag.TotalPrice = totalPrice.ToString("0.##");
            //Toplam Kazanç
            ViewBag.TotalTickets = _context.Destinations.Sum(d => d.total_tickets); //Toplam Satılan bilet sayısı
            ViewBag.TotalSoldTickets = _context.Destinations.Sum(d => d.sold_ticket); //Satılan bilet sayısı

            return View();
        }
    }
}