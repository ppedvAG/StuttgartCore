using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCaching;
using Microsoft.AspNetCore.ResponseCaching.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul05
{
    public class ResponseCachingForced: ResponseCachingPolicyProvider
    {
        public override bool AllowCacheLookup(ResponseCachingContext context)
        {
            return true;
        }

        public override bool AllowCacheStorage(ResponseCachingContext context)
        {
            return true;
        }
    }

    // geklaut https://github.com/aspnet/ResponseCaching/blob/master/src/Microsoft.AspNetCore.ResponseCaching/ResponseCachingServicesExtensions.cs
    public static class ResponseCachingServicesExtensions
    {
        public static IServiceCollection AddResponseCachingForced(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IResponseCachingPolicyProvider, ResponseCachingForced>());
            services.TryAdd(ServiceDescriptor.Singleton<IResponseCachingKeyProvider, ResponseCachingKeyProvider>());
            return services;
        }
       
        public static IServiceCollection AddResponseCaching(this IServiceCollection services, Action<ResponseCachingOptions> configureOptions)
        {
            services.Configure(configureOptions);
            services.AddResponseCaching();
            return services;
        }

    }
}

