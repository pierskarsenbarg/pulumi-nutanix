// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetTemplateV2TemplateVersionSpecVmSpecDiskResult
    {
        /// <summary>
        /// Defines a NIC emulated by the hypervisor
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskBackingInfoResult> BackingInfos;
        /// <summary>
        /// Virtual Machine disk (VM disk).
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskDiskAddressResult> DiskAddresses;
        /// <summary>
        /// The identifier of a Template.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskLinkResult> Links;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetTemplateV2TemplateVersionSpecVmSpecDiskResult(
            ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskBackingInfoResult> backingInfos,

            ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskDiskAddressResult> diskAddresses,

            string extId,

            ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecDiskLinkResult> links,

            string tenantId)
        {
            BackingInfos = backingInfos;
            DiskAddresses = diskAddresses;
            ExtId = extId;
            Links = links;
            TenantId = tenantId;
        }
    }
}
