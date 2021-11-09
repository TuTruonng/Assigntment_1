using System;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using KhoaLuanTotNghiep_BackEnd.Helpers;
using KhoaLuanTotNghiep_BackEnd.Security.Authorization.Requirements;
using ShareModel.Constant;

namespace KhoaLuanTotNghiep_BackEnd.Security.Authorization.Handlers
{
    public class AdminRoleHandler : AuthorizationHandler<AdminRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                    AdminRoleRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == JwtClaimTypes.Role &&
                                            c.Issuer == WebHostHelper.GetWebUrl()))
            {
                return Task.CompletedTask;
            }

            var adminClaim = context.User.FindFirst(c => c.Type == JwtClaimTypes.Role && 
                                                      c.Issuer == WebHostHelper.GetWebUrl() &&
                                                      c.Value == SecurityConstants.ADMINISTRATION_ROLE).Value;

            if (!string.IsNullOrEmpty(adminClaim))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}