﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebCovid19.Filters
{
    public class LoginFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //HttpContext.Current.Session["action"] = action;
            //HttpContext.Current.Session["controller"] = controller;
            if (HttpContext.Current.Session["UserId"] as string == String.Empty)
            {
                string action = filterContext.RouteData.Values["action"].ToString();
                string controller = filterContext.RouteData.Values["controller"].ToString();


                HttpContext.Current.Session["action"] = action;
                HttpContext.Current.Session["controller"] = controller;
                filterContext.Result = new RedirectToRouteResult
                    (
                        new RouteValueDictionary
                        {
                            {"Controller", "Usuario" },
                            {"Action", "Login" },
                            {"mensaje", $"Para acceder a {action} debe loguearse"}
                        }
                    );
            }
       


        }




    }
}