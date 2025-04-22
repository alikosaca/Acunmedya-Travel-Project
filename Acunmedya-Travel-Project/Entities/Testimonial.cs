using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acunmedya_Travel_Project.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}