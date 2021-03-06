﻿using Site.Util;
using System;
using System.Threading;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = RouteData.Values["culture"] as string;


            if (cultureName == null)
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ? Request.UserLanguages[0] : null;

            cultureName = CultureHelper.GetImplementedCulture(cultureName);

            if (RouteData.Values["culture"] as string != cultureName)
            {
                RouteData.Values["culture"] = cultureName.ToLowerInvariant();

                Response.RedirectToRoute(RouteData.Values);
            }

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}