using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KhoaLuanTotNghiep_BackEnd.Helpers
{
    public static class WebHostHelper
    {
        public static string GetWebRootPath()
        {
            var _accessor = new HttpContextAccessor();

            return _accessor.HttpContext
                                .RequestServices
                                .GetRequiredService<IWebHostEnvironment>()
                                .WebRootPath;

        }

        public static string GetWebUrl()
        {
            var _accessor = new HttpContextAccessor();

             return _accessor.HttpContext
                                .RequestServices
                                .GetRequiredService<IConfiguration>()
                                .GetValue<string>("EndPoints:BackEnd");
        }
    }
}
