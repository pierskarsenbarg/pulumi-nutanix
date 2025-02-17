# Nutanix Resource Provider

The Nutanix Resource Provider lets you manage [Nutanix](https://nutanix.com) resources.

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

| Option     | Required/Optional | Description                                                                                                                                         |
| ---------- | ----------------- | --------------------------------------------------------------------------------------------------------------------------------------------------- |
| `username` | Required          | This is the username for the Prism Elements or Prism Central instance. This can also be specified with the `NUTANIX_USERNAME` environment variable. |
| `password` | Required          | This is the password for the Prism Elements or Prism Central instance. This can also be specified with the `NUTANIX_PASSWORD` environment variable. |
| `endpoint` | Required          | This is the endpoint for the Prism Elements or Prism Central instance. This can also be specified with the NUTANIX_ENDPOINT environment variable.   |
| `insecure` | Optional          | This specifies whether to allow verify ssl certificates. This can also be specified with `NUTANIX_INSECURE`. Defaults to `false`.                     |
| `port`     | Optional          | This is the port for the Prism Elements or Prism Central instance. This can also be specified with the `NUTANIX_PORT` environment variable. Defaults to `9440`. |

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/nutanix/api-docs/).
