// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetFloatingIps
    {
        /// <summary>
        /// Provides a datasource to retrieve all the floating IPs .
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var test = Output.Create(Nutanix.GetFloatingIps.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFloatingIpsResult> InvokeAsync(GetFloatingIpsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFloatingIpsResult>("nutanix:index/getFloatingIps:getFloatingIps", args ?? new GetFloatingIpsArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to retrieve all the floating IPs .
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var test = Output.Create(Nutanix.GetFloatingIps.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetFloatingIpsResult> Invoke(GetFloatingIpsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFloatingIpsResult>("nutanix:index/getFloatingIps:getFloatingIps", args ?? new GetFloatingIpsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFloatingIpsArgs : Pulumi.InvokeArgs
    {
        [Input("metadatas")]
        private List<Inputs.GetFloatingIpsMetadataArgs>? _metadatas;
        public List<Inputs.GetFloatingIpsMetadataArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new List<Inputs.GetFloatingIpsMetadataArgs>());
            set => _metadatas = value;
        }

        public GetFloatingIpsArgs()
        {
        }
    }

    public sealed class GetFloatingIpsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("metadatas")]
        private InputList<Inputs.GetFloatingIpsMetadataInputArgs>? _metadatas;
        public InputList<Inputs.GetFloatingIpsMetadataInputArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new InputList<Inputs.GetFloatingIpsMetadataInputArgs>());
            set => _metadatas = value;
        }

        public GetFloatingIpsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFloatingIpsResult
    {
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetFloatingIpsEntityResult> Entities;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetFloatingIpsMetadataResult> Metadatas;

        [OutputConstructor]
        private GetFloatingIpsResult(
            string apiVersion,

            ImmutableArray<Outputs.GetFloatingIpsEntityResult> entities,

            string id,

            ImmutableArray<Outputs.GetFloatingIpsMetadataResult> metadatas)
        {
            ApiVersion = apiVersion;
            Entities = entities;
            Id = id;
            Metadatas = metadatas;
        }
    }
}