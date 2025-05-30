using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acunmedya_Travel_Project.Entities
{
    public class Destination
    {
        [Key]
        public int destination_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public string days_trip { get; set; }
        public int total_tickets { get; set; }
        public int sold_ticket { get; set; }
        public decimal price { get; set; }
        public int category_id { get; set; }
        [ForeignKey("category_id")]
        public Category category { get; set; }

    }
}