using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activit5.Controllers {
    public class Attributes : FilterAttribute, IAuthorizationFilter {

        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext) {

            if (System.Web.HttpContext.Current.Session["user"] == null)
                filterContext.Result = new RedirectResult("/Login/Index");
        }

    }
}