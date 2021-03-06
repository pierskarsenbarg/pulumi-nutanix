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
    public static class GetPermissions
    {
        /// <summary>
        /// Provides a datasource to retrieve all the permissions.
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
        ///         var permissions = Output.Create(Nutanix.GetPermission.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPermissionsResult> InvokeAsync(GetPermissionsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPermissionsResult>("nutanix:index/getPermissions:getPermissions", args ?? new GetPermissionsArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to retrieve all the permissions.
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
        ///         var permissions = Output.Create(Nutanix.GetPermission.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetPermissionsResult> Invoke(GetPermissionsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPermissionsResult>("nutanix:index/getPermissions:getPermissions", args ?? new GetPermissionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPermissionsArgs : Pulumi.InvokeArgs
    {
        [Input("metadatas")]
        private List<Inputs.GetPermissionsMetadataArgs>? _metadatas;
        public List<Inputs.GetPermissionsMetadataArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new List<Inputs.GetPermissionsMetadataArgs>());
            set => _metadatas = value;
        }

        public GetPermissionsArgs()
        {
        }
    }

    public sealed class GetPermissionsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("metadatas")]
        private InputList<Inputs.GetPermissionsMetadataInputArgs>? _metadatas;
        public InputList<Inputs.GetPermissionsMetadataInputArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new InputList<Inputs.GetPermissionsMetadataInputArgs>());
            set => _metadatas = value;
        }

        public GetPermissionsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPermissionsResult
    {
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetPermissionsEntityResult> Entities;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetPermissionsMetadataResult> Metadatas;

        [OutputConstructor]
        private GetPermissionsResult(
            string apiVersion,

            ImmutableArray<Outputs.GetPermissionsEntityResult> entities,

            string id,

            ImmutableArray<Outputs.GetPermissionsMetadataResult> metadatas)
        {
            ApiVersion = apiVersion;
            Entities = entities;
            Id = id;
            Metadatas = metadatas;
        }
    }
}
