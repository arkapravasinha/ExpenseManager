using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManager.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public void LogOff()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
             OpenIdConnectAuthenticationDefaults.AuthenticationType,
             CookieAuthenticationDefaults.AuthenticationType);
        }

        public void SignIn()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }
    }
}