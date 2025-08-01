// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetKarbonClusterKubeConfig
    {
        /// <summary>
        /// Describes the SSH config from a Karbon Cluster
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var configbyid = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterId = "&lt;YOUR-CLUSTER-ID&gt;",
        ///     });
        /// 
        ///     var configbyname = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterName = "&lt;YOUR-CLUSTER-NAME&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetKarbonClusterKubeConfigResult> InvokeAsync(GetKarbonClusterKubeConfigArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetKarbonClusterKubeConfigResult>("nutanix:index/getKarbonClusterKubeConfig:getKarbonClusterKubeConfig", args ?? new GetKarbonClusterKubeConfigArgs(), options.WithDefaults());

        /// <summary>
        /// Describes the SSH config from a Karbon Cluster
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var configbyid = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterId = "&lt;YOUR-CLUSTER-ID&gt;",
        ///     });
        /// 
        ///     var configbyname = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterName = "&lt;YOUR-CLUSTER-NAME&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetKarbonClusterKubeConfigResult> Invoke(GetKarbonClusterKubeConfigInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetKarbonClusterKubeConfigResult>("nutanix:index/getKarbonClusterKubeConfig:getKarbonClusterKubeConfig", args ?? new GetKarbonClusterKubeConfigInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Describes the SSH config from a Karbon Cluster
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var configbyid = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterId = "&lt;YOUR-CLUSTER-ID&gt;",
        ///     });
        /// 
        ///     var configbyname = Nutanix.GetKarbonClusterKubeConfig.Invoke(new()
        ///     {
        ///         KarbonClusterName = "&lt;YOUR-CLUSTER-NAME&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetKarbonClusterKubeConfigResult> Invoke(GetKarbonClusterKubeConfigInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetKarbonClusterKubeConfigResult>("nutanix:index/getKarbonClusterKubeConfig:getKarbonClusterKubeConfig", args ?? new GetKarbonClusterKubeConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetKarbonClusterKubeConfigArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Represents karbon cluster uuid
        /// </summary>
        [Input("karbonClusterId")]
        public string? KarbonClusterId { get; set; }

        /// <summary>
        /// Represents the name of karbon cluster
        /// </summary>
        [Input("karbonClusterName")]
        public string? KarbonClusterName { get; set; }

        public GetKarbonClusterKubeConfigArgs()
        {
        }
        public static new GetKarbonClusterKubeConfigArgs Empty => new GetKarbonClusterKubeConfigArgs();
    }

    public sealed class GetKarbonClusterKubeConfigInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Represents karbon cluster uuid
        /// </summary>
        [Input("karbonClusterId")]
        public Input<string>? KarbonClusterId { get; set; }

        /// <summary>
        /// Represents the name of karbon cluster
        /// </summary>
        [Input("karbonClusterName")]
        public Input<string>? KarbonClusterName { get; set; }

        public GetKarbonClusterKubeConfigInvokeArgs()
        {
        }
        public static new GetKarbonClusterKubeConfigInvokeArgs Empty => new GetKarbonClusterKubeConfigInvokeArgs();
    }


    [OutputType]
    public sealed class GetKarbonClusterKubeConfigResult
    {
        public readonly string AccessToken;
        public readonly string ClusterCaCertificate;
        public readonly string ClusterUrl;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? KarbonClusterId;
        public readonly string? KarbonClusterName;
        public readonly string Name;

        [OutputConstructor]
        private GetKarbonClusterKubeConfigResult(
            string accessToken,

            string clusterCaCertificate,

            string clusterUrl,

            string id,

            string? karbonClusterId,

            string? karbonClusterName,

            string name)
        {
            AccessToken = accessToken;
            ClusterCaCertificate = clusterCaCertificate;
            ClusterUrl = clusterUrl;
            Id = id;
            KarbonClusterId = karbonClusterId;
            KarbonClusterName = karbonClusterName;
            Name = name;
        }
    }
}
