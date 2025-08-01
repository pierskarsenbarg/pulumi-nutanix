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
    public sealed class GetTemplateV2TemplateVersionSpecVmSpecGpusResult
    {
        /// <summary>
        /// The device Id of the GPU.
        /// </summary>
        public readonly int DeviceId;
        /// <summary>
        /// The identifier of a Template.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// Fraction of the physical GPU assigned.
        /// </summary>
        public readonly int Fraction;
        /// <summary>
        /// GPU frame buffer size in bytes.
        /// </summary>
        public readonly int FrameBufferSizeBytes;
        /// <summary>
        /// Last determined guest driver version.
        /// </summary>
        public readonly string GuestDriverVersion;
        /// <summary>
        /// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecGpusLinkResult> Links;
        /// <summary>
        /// The mode of this GPU.
        /// </summary>
        public readonly string Mode;
        /// <summary>
        /// Name of the GPU resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Number of supported virtual display heads.
        /// </summary>
        public readonly int NumVirtualDisplayHeads;
        /// <summary>
        /// The (S)egment:(B)us:(D)evice.(F)unction hardware address. See
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecGpusPciAddressResult> PciAddresses;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The vendor of the GPU.
        /// </summary>
        public readonly string Vendor;

        [OutputConstructor]
        private GetTemplateV2TemplateVersionSpecVmSpecGpusResult(
            int deviceId,

            string extId,

            int fraction,

            int frameBufferSizeBytes,

            string guestDriverVersion,

            ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecGpusLinkResult> links,

            string mode,

            string name,

            int numVirtualDisplayHeads,

            ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecGpusPciAddressResult> pciAddresses,

            string tenantId,

            string vendor)
        {
            DeviceId = deviceId;
            ExtId = extId;
            Fraction = fraction;
            FrameBufferSizeBytes = frameBufferSizeBytes;
            GuestDriverVersion = guestDriverVersion;
            Links = links;
            Mode = mode;
            Name = name;
            NumVirtualDisplayHeads = numVirtualDisplayHeads;
            PciAddresses = pciAddresses;
            TenantId = tenantId;
            Vendor = vendor;
        }
    }
}
