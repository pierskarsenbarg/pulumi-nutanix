// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("volumeGroupExtId")]
        public Input<string>? VolumeGroupExtId { get; set; }

        public TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceGetArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceGetArgs Empty => new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceGetArgs();
    }
}
