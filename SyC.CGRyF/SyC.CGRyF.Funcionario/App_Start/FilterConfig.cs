﻿using System.Web;
using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
