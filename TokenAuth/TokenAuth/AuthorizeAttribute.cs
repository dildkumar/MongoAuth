using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuth
{
    public class AuthorizeAttribute : System.Web.Http.AuthorizeAttribute
    {

        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actioncontext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(actioncontext);
            }
            else
            {
                actioncontext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
        }
    }
}