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
    public sealed class GetTemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceResult
    {
        /// <summary>
        /// The globally unique identifier of an ADSF volume group. It should be of type UUID.
        /// </summary>
        public readonly string VolumeGroupExtId;

        [OutputConstructor]
        private GetTemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceResult(string volumeGroupExtId)
        {
            VolumeGroupExtId = volumeGroupExtId;
        }
    }
}
