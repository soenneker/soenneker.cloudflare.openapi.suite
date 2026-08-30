[![](https://img.shields.io/nuget/v/soenneker.cloudflare.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.openapi.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.openapi.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cloudflare.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.openapi.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.openapi.suite/actions/workflows/codeql.yml)

# Soenneker.Cloudflare.OpenApi.Suite

A dependency-injection registration bundle for selected Cloudflare OpenAPI utility packages.

## Installation

```bash
dotnet add package Soenneker.Cloudflare.OpenApi.Suite
```

## Configuration

```json
{
  "Cloudflare": {
    "ApiKey": "your-api-token"
  }
}
```

The token needs only the permissions required by the utilities your application actually calls. Prefer a scoped token rather than a global API key.

## Registration

```csharp
using Soenneker.Cloudflare.OpenApi.Suite.Registrars;

services.AddCloudflareOpenApiSuiteAsScoped();
```

Use `AddCloudflareOpenApiSuiteAsSingleton()` when all utility wrappers should be application-wide singletons. Both registrations reuse the shared Cloudflare client utility supplied by the component packages.

## Included utilities

The suite registers:

- Email Routing
- Security
- Speed
- Web Analytics
- Caching
- SSL
- Scrape Shield
- DNSSEC settings
- Workers
- Pages
- Workers KV
- Registrar
- Workers AI
- R2

It does not register every package in the `Soenneker.Cloudflare` family. In particular, DNS records, zones, Turnstile, request validators, middleware, and the browser downloader must be installed and registered separately when needed.
