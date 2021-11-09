using Microsoft.AspNetCore.Authorization;

namespace KhoaLuanTotNghiep_BackEnd.Security.Authorization.Requirements
{
    public class AdminRoleRequirement : IAuthorizationRequirement
    {
        public AdminRoleRequirement() {}
    }
}
