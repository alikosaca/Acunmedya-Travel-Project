﻿using System.Web;
using System.Web.Mvc;

namespace Acunmedya_Travel_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
