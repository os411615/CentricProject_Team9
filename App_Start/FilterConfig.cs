﻿using System.Web;
using System.Web.Mvc;

namespace CentricProject_Team9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
