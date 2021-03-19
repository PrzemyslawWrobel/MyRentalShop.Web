using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRentalShop.Web.Filters
{
    public class CheckPermission : Attribute, IAuthorizationFilter
    {
        private readonly string _permission;
        public CheckPermission(string permission)
        {
            _permission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool IsAuthorized = CheckUserPermission(context.HttpContext.User, _permission);
        }
    }
}
