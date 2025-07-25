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
    public static class GetVmRecoveryPointInfoV2
    {
        /// <summary>
        /// Get the VM recovery point identified by ex_id.
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
        ///     var rp_vm_info = Nutanix.GetVmRecoveryPointInfoV2.Invoke(new()
        ///     {
        ///         ExtId = "85ac418e-c847-45ab-9816-40a3c4de148c",
        ///         RecoveryPointExtId = "af1070f7-c946-49da-9b17-e337e06e0a18",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetVmRecoveryPointInfoV2Result> InvokeAsync(GetVmRecoveryPointInfoV2Args args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVmRecoveryPointInfoV2Result>("nutanix:index/getVmRecoveryPointInfoV2:getVmRecoveryPointInfoV2", args ?? new GetVmRecoveryPointInfoV2Args(), options.WithDefaults());

        /// <summary>
        /// Get the VM recovery point identified by ex_id.
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
        ///     var rp_vm_info = Nutanix.GetVmRecoveryPointInfoV2.Invoke(new()
        ///     {
        ///         ExtId = "85ac418e-c847-45ab-9816-40a3c4de148c",
        ///         RecoveryPointExtId = "af1070f7-c946-49da-9b17-e337e06e0a18",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetVmRecoveryPointInfoV2Result> Invoke(GetVmRecoveryPointInfoV2InvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVmRecoveryPointInfoV2Result>("nutanix:index/getVmRecoveryPointInfoV2:getVmRecoveryPointInfoV2", args ?? new GetVmRecoveryPointInfoV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Get the VM recovery point identified by ex_id.
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
        ///     var rp_vm_info = Nutanix.GetVmRecoveryPointInfoV2.Invoke(new()
        ///     {
        ///         ExtId = "85ac418e-c847-45ab-9816-40a3c4de148c",
        ///         RecoveryPointExtId = "af1070f7-c946-49da-9b17-e337e06e0a18",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetVmRecoveryPointInfoV2Result> Invoke(GetVmRecoveryPointInfoV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetVmRecoveryPointInfoV2Result>("nutanix:index/getVmRecoveryPointInfoV2:getVmRecoveryPointInfoV2", args ?? new GetVmRecoveryPointInfoV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVmRecoveryPointInfoV2Args : global::Pulumi.InvokeArgs
    {
        [Input("diskRecoveryPoints")]
        private List<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointArgs>? _diskRecoveryPoints;

        /// <summary>
        /// array of disk recovery points.
        /// </summary>
        public List<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointArgs> DiskRecoveryPoints
        {
            get => _diskRecoveryPoints ?? (_diskRecoveryPoints = new List<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointArgs>());
            set => _diskRecoveryPoints = value;
        }

        /// <summary>
        /// The external identifier that can be used to identify a VM recovery point.
        /// </summary>
        [Input("extId", required: true)]
        public string ExtId { get; set; } = null!;

        /// <summary>
        /// The external identifier that can be used to retrieve the recovery point using its URL.
        /// </summary>
        [Input("recoveryPointExtId", required: true)]
        public string RecoveryPointExtId { get; set; } = null!;

        public GetVmRecoveryPointInfoV2Args()
        {
        }
        public static new GetVmRecoveryPointInfoV2Args Empty => new GetVmRecoveryPointInfoV2Args();
    }

    public sealed class GetVmRecoveryPointInfoV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("diskRecoveryPoints")]
        private InputList<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointInputArgs>? _diskRecoveryPoints;

        /// <summary>
        /// array of disk recovery points.
        /// </summary>
        public InputList<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointInputArgs> DiskRecoveryPoints
        {
            get => _diskRecoveryPoints ?? (_diskRecoveryPoints = new InputList<Inputs.GetVmRecoveryPointInfoV2DiskRecoveryPointInputArgs>());
            set => _diskRecoveryPoints = value;
        }

        /// <summary>
        /// The external identifier that can be used to identify a VM recovery point.
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        /// <summary>
        /// The external identifier that can be used to retrieve the recovery point using its URL.
        /// </summary>
        [Input("recoveryPointExtId", required: true)]
        public Input<string> RecoveryPointExtId { get; set; } = null!;

        public GetVmRecoveryPointInfoV2InvokeArgs()
        {
        }
        public static new GetVmRecoveryPointInfoV2InvokeArgs Empty => new GetVmRecoveryPointInfoV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetVmRecoveryPointInfoV2Result
    {
        /// <summary>
        /// User-defined application-consistent properties for the recovery point.
        /// *
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVmRecoveryPointInfoV2ApplicationConsistentPropertyResult> ApplicationConsistentProperties;
        /// <summary>
        /// External identifier of the Consistency group which the VM was part of at the time of recovery point creation.
        /// </summary>
        public readonly string ConsistencyGroupExtId;
        /// <summary>
        /// array of disk recovery points.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVmRecoveryPointInfoV2DiskRecoveryPointResult> DiskRecoveryPoints;
        /// <summary>
        /// recovery point UUID
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVmRecoveryPointInfoV2LinkResult> Links;
        /// <summary>
        /// Location agnostic identifier of the Recovery point.
        /// </summary>
        public readonly string LocationAgnosticId;
        public readonly string RecoveryPointExtId;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Category key-value pairs associated with the VM at the time of recovery point creation. The category key and value are separated by '/'. For example, a category with key 'dept' and value 'hr' is displayed as 'dept/hr'.
        /// </summary>
        public readonly ImmutableArray<string> VmCategories;
        /// <summary>
        /// VM external identifier which is captured as a part of this recovery point.
        /// </summary>
        public readonly string VmExtId;

        [OutputConstructor]
        private GetVmRecoveryPointInfoV2Result(
            ImmutableArray<Outputs.GetVmRecoveryPointInfoV2ApplicationConsistentPropertyResult> applicationConsistentProperties,

            string consistencyGroupExtId,

            ImmutableArray<Outputs.GetVmRecoveryPointInfoV2DiskRecoveryPointResult> diskRecoveryPoints,

            string extId,

            string id,

            ImmutableArray<Outputs.GetVmRecoveryPointInfoV2LinkResult> links,

            string locationAgnosticId,

            string recoveryPointExtId,

            string tenantId,

            ImmutableArray<string> vmCategories,

            string vmExtId)
        {
            ApplicationConsistentProperties = applicationConsistentProperties;
            ConsistencyGroupExtId = consistencyGroupExtId;
            DiskRecoveryPoints = diskRecoveryPoints;
            ExtId = extId;
            Id = id;
            Links = links;
            LocationAgnosticId = locationAgnosticId;
            RecoveryPointExtId = recoveryPointExtId;
            TenantId = tenantId;
            VmCategories = vmCategories;
            VmExtId = vmExtId;
        }
    }
}
