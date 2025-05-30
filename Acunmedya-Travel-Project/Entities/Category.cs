using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acunmedya_Travel_Project.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}