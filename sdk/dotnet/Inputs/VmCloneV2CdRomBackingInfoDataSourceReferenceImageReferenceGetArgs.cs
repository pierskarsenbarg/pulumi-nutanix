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

    public sealed class VmCloneV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("imageExtId")]
        public Input<string>? ImageExtId { get; set; }

        public VmCloneV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs()
        {
        }
        public static new VmCloneV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs Empty => new VmCloneV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs();
    }
}
