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
    public sealed class GetNdbTmsCapabilityCapabilitySnapshotMetadataInfoBpgConfigStorageLogDiskResult
    {
        public readonly double Count;
        public readonly double Size;

        [OutputConstructor]
        private GetNdbTmsCapabilityCapabilitySnapshotMetadataInfoBpgConfigStorageLogDiskResult(
            double count,

            double size)
        {
            Count = count;
            Size = size;
        }
    }
}
