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

    public sealed class TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("volumeGroupExtId")]
        public Input<string>? VolumeGroupExtId { get; set; }

        public TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceArgs Empty => new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoAdfsVolumeGroupReferenceArgs();
    }
}
