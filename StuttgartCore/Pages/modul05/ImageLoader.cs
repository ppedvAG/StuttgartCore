using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul05
{
    public class ImageLoader
    {
        public ImageLoader(RequestDelegate _next)
        {

        }
        public async Task Invoke(HttpContext context)
        {
            var img = context.Request.Query["img"];
            var pfad = Path.Combine(AppDomain.CurrentDomain.GetData("MapPath").ToString(),
                "wwwroot", "app_data",
               img);
            await context.Response.SendFileAsync(pfad);

        }

    }
    public static class ImageLoaderExtension
    {

        public static IApplicationBuilder UseImageLoader(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageLoader>(); ;
        }

    }
}