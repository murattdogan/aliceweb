using Alice.Service.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Admin.Filters
{
    public class AuthorizationAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.GetString("luxurydbadmin") is null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                                new
                                {
                                    controller = "Home",
                                    action = "Login"
                                }));
            }
            else
            {
                if (filterContext.Controller is Controller c)
                {
                    c.ViewBag.User = JsonConvert.DeserializeObject<UserDTO>(filterContext.HttpContext.Session.GetString("luxurydbadmin"));
                }
            }
        }
    }
}
