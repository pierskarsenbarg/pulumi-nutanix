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
    public sealed class GetNdbCloneInfoBpgConfigStorageResult
    {
        public readonly ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageArchiveStorageResult> ArchiveStorages;
        public readonly ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageDataDiskResult> DataDisks;
        public readonly ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageLogDiskResult> LogDisks;

        [OutputConstructor]
        private GetNdbCloneInfoBpgConfigStorageResult(
            ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageArchiveStorageResult> archiveStorages,

            ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageDataDiskResult> dataDisks,

            ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigStorageLogDiskResult> logDisks)
        {
            ArchiveStorages = archiveStorages;
            DataDisks = dataDisks;
            LogDisks = logDisks;
        }
    }
}
