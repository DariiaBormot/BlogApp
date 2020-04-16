using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace BlogWebAPI.Filters
{
    public class CustomAuthorizeFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (Authorized(actionContext))
            {
                return;
            }

            HandleUnauthorizedRequest(actionContext);
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var message = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            throw new HttpResponseException(message);
        }

        private bool Authorized(HttpActionContext actionContext)
        {
            try
            {
                var ipAdresses = HttpContext.Current.Request.UserHostAddress;
                if (!IsIpAllowed(ipAdresses.Trim()))
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsIpAllowed(string adress)
        {
            if (!string.IsNullOrEmpty(adress))
            {
                var allowedAddress = ConfigurationManager.AppSettings["AllowedIpAddress"];

                if (string.IsNullOrEmpty(allowedAddress))
                {
                    return true;
                }

                string[] addresses = allowedAddress.Split(',');

                return addresses.Where(a => a.Trim().Equals(adress, StringComparison.InvariantCultureIgnoreCase)).Any();
            }
            return false;
        }
    }
}