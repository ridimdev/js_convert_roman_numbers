﻿using System.Web;
using System.Web.Mvc;

namespace js_validate_roman_numbers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
