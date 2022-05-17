using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using static Utils;

namespace VideoShop.WebUI
{
    public class AdminAthentication : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var isLoggedIn = IsLoggedIn(context.HttpContext);

            if (!isLoggedIn)
            {
                throw new AuthenticationException("you are not Logged in");
            }
                        }

        private static bool IsLoggedIn(HttpContext context)
        {
            return context.User != null &&
                   context.User.Identity.IsAuthenticated;
        }


    }
}
