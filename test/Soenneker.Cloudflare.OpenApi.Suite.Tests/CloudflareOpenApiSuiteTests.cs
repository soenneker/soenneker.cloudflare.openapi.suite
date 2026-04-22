using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.OpenApi.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareOpenApiSuiteTests : HostedUnitTest
{
    public CloudflareOpenApiSuiteTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
