﻿﻿using System.Web.Mvc;
using System.Web.Routing;
using FluentSecurity;

namespace MiniAmazon.Web.Infrastructure
{
    public class DenyAnonymousAccessPolicyViolationHandler : IPolicyViolationHandler
    {
        #region IPolicyViolationHandler Members

        public ActionResult Handle(PolicyViolationException exception)
        {
            return new RedirectToRouteResult("SignIn",
                                             new RouteValueDictionary { { "Error", "Debes iniciar sesion para poder utilizar esta sección" } });
        }



        public class RequireRolePolicyViolationHandler : IPolicyViolationHandler
        {

            public ActionResult Handle(PolicyViolationException exception)
            {
                return new RedirectToRouteResult("Error",
                                           new RouteValueDictionary { { "Error", "Página no encontrada." } });

            }
        }
        #endregion
    }
}