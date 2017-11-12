using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web;

namespace MVC_Samp.AuthData
{
    public class Filter:ActionFilterAttribute,IAuthenticationFilter
   {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
         
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           
        }

       // public void 
    }
}