using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Acunmedya_Travel_Project.Entities
{
    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
    }
}