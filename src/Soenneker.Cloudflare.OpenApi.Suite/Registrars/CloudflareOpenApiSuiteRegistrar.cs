using Microsoft.Extensions.DependencyInjection;
using Soenneker.Cloudflare.Caching.Registrars;
using Soenneker.Cloudflare.DnsSettings.Registrars;
using Soenneker.Cloudflare.EmailRouting.Registrars;
using Soenneker.Cloudflare.Pages.Registrars;
using Soenneker.Cloudflare.ScrapeShield.Registrars;
using Soenneker.Cloudflare.Security.Registrars;
using Soenneker.Cloudflare.Speed.Registrars;
using Soenneker.Cloudflare.Ssl.Registrars;
using Soenneker.Cloudflare.WebAnalytics.Registrars;
using Soenneker.Cloudflare.Workers.Registrars;

namespace Soenneker.Cloudflare.OpenApi.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Cloudflare's OpenApi operations
/// </summary>
public static class CloudflareOpenApiSuiteRegistrar
{
    /// <summary>
    /// Registers all Cloudflare OpenApi utilities as singletons in the service collection.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCloudflareOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddCloudflareEmailRoutingUtilAsSingleton()
                .AddCloudflareSecurityUtilAsSingleton()
                .AddCloudflareSpeedUtilAsSingleton()
                .AddCloudflareWebAnalyticsUtilAsSingleton()
                .AddCloudflareCachingUtilAsSingleton()
                .AddCloudflareSslUtilAsSingleton()
                .AddCloudflareScrapeShieldUtilAsSingleton()
                .AddCloudflareDnsSettingsUtilAsSingleton()
                .AddCloudflareWorkersUtilAsSingleton()
                .AddCloudflarePagesUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Registers all Cloudflare OpenApi utilities as scoped in the service collection.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCloudflareOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddCloudflareEmailRoutingUtilAsScoped()
                .AddCloudflareSecurityUtilAsScoped()
                .AddCloudflareSpeedUtilAsScoped()
                .AddCloudflareWebAnalyticsUtilAsScoped()
                .AddCloudflareCachingUtilAsScoped()
                .AddCloudflareSslUtilAsScoped()
                .AddCloudflareScrapeShieldUtilAsScoped()
                .AddCloudflareDnsSettingsUtilAsScoped()
                .AddCloudflareWorkersUtilAsScoped()
                .AddCloudflarePagesUtilAsScoped();

        return services;
    }
}