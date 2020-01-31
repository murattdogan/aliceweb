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
        private readonly IHttpContextAccessor _contextAccessor;
        public AuthorizationAttribute(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (_contextAccessor.HttpContext.Session.GetString("luxurydbadmin") == null)
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
                    c.ViewBag.User = JsonConvert.DeserializeObject<UserDTO>(_contextAccessor.HttpContext.Session.GetString("luxurydbadmin"));
                }
            }
        }
    }
}
