using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acunmedya_Travel_Project.Entities
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string DaysTrip { get; set; }
        public string ImageUrl { get; set; }
    }
}