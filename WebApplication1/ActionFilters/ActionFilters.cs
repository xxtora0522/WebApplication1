using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace WebApplication1.ActionFilters
{
    public class ActionFilters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            String sessionId = filterContext.HttpContext.Session.SessionID;
            Object loginId = filterContext.HttpContext.Session["loginId"];
            String applicationId = filterContext.HttpContext.Application[loginId.ToString()].ToString();

            if(!String.Equals(sessionId, applicationId))
            {
                filterContext.HttpContext.Session.Abandon();
                FormsAuthentication.SignOut();
                //return RedirectToAction("Auth", "Index");
                //filterContext.Result = new RedirectToRouteResult("Auth", routeValues);

                filterContext.Result = new RedirectResult("/Auth/Login");
                return;


            }
            base.OnActionExecuting(filterContext);
        }
    }
}