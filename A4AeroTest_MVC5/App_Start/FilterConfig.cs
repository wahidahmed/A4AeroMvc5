﻿using System.Web;
using System.Web.Mvc;

namespace A4AeroTest_MVC5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
