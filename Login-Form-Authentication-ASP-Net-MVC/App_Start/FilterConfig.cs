﻿using System.Web;
using System.Web.Mvc;

namespace Login_Form_Authentication_ASP_Net_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
