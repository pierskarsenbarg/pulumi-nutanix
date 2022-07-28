# Nutanix Resource Provider

The Nutanix Resource Provider lets you manage [Nutanix](http://example.com) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pierskarsenbarg/pulumi-nutanix
```

or `yarn`:

```bash
yarn add @pierskarsenbarg/pulumi-nutanix
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumi_nutanix
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package PiersKarsenbarg.Nutanix
```

## Configuration

The following configuration points are available for the `nutanix` provider:

- `nutanix:apiKey` (environment: `NUTANIX_API_KEY`) - the API key for `nutanix`
- `nutanix:region` (environment: `NUTANIX_REGION`) - the region in which to deploy resources

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/foo/api-docs/).
