﻿using System.Web;
using System.Web.Mvc;

namespace Lecture15_FirstMVCApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
