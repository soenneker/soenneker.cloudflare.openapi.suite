using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cloudflare.OpenApi.Suite.Tests;

[Collection("Collection")]
public sealed class CloudflareOpenApiSuiteTests : FixturedUnitTest
{
    public CloudflareOpenApiSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
