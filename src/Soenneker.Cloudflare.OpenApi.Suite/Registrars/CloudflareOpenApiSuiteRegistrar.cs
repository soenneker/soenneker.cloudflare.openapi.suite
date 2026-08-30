using Microsoft.Extensions.DependencyInjection;
using Soenneker.Cloudflare.Caching.Registrars;
using Soenneker.Cloudflare.DnsSettings.Registrars;
using Soenneker.Cloudflare.EmailRouting.Registrars;
using Soenneker.Cloudflare.Pages.Registrars;
using Soenneker.Cloudflare.R2.Registrars;
using Soenneker.Cloudflare.Registrar.Registrars;
using Soenneker.Cloudflare.ScrapeShield.Registrars;
using Soenneker.Cloudflare.Security.Registrars;
using Soenneker.Cloudflare.Speed.Registrars;
using Soenneker.Cloudflare.Ssl.Registrars;
using Soenneker.Cloudflare.WebAnalytics.Registrars;
using Soenneker.Cloudflare.Workers.Ai.Registrars;
using Soenneker.Cloudflare.Workers.Kv.Registrars;
using Soenneker.Cloudflare.Workers.Registrars;

namespace Soenneker.Cloudflare.OpenApi.Suite.Registrars;

/// <summary>
/// Registers the selected Cloudflare utilities included by this package.
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
        services.AddCloudflareEmailRoutingUtilAsSingleton().AddCloudflareSecurityUtilAsSingleton()
                .AddCloudflareSpeedUtilAsSingleton().AddCloudflareWebAnalyticsUtilAsSingleton()
                .AddCloudflareCachingUtilAsSingleton().AddCloudflareSslUtilAsSingleton()
                .AddCloudflareScrapeShieldUtilAsSingleton().AddCloudflareDnsSettingsUtilAsSingleton()
                .AddCloudflareWorkersUtilAsSingleton().AddCloudflarePagesUtilAsSingleton()
                .AddCloudflareWorkersKvUtilAsSingleton().AddCloudflareRegistrarUtilAsSingleton()
                .AddCloudflareWorkersAiUtilAsSingleton().AddCloudflareR2UtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Registers all Cloudflare OpenApi utilities as scoped in the service collection.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCloudflareOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddCloudflareEmailRoutingUtilAsScoped().AddCloudflareSecurityUtilAsScoped()
                .AddCloudflareSpeedUtilAsScoped().AddCloudflareWebAnalyticsUtilAsScoped()
                .AddCloudflareCachingUtilAsScoped().AddCloudflareSslUtilAsScoped()
                .AddCloudflareScrapeShieldUtilAsScoped().AddCloudflareDnsSettingsUtilAsScoped()
                .AddCloudflareWorkersUtilAsScoped().AddCloudflarePagesUtilAsScoped()
                .AddCloudflareWorkersKvUtilAsScoped().AddCloudflareRegistrarUtilAsScoped()
                .AddCloudflareWorkersAiUtilAsScoped().AddCloudflareR2UtilAsScoped();

        return services;
    }
}
