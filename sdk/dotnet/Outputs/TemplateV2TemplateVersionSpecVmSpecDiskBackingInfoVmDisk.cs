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
    public sealed class TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDisk
    {
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSource> DataSources;
        public readonly string? DiskExtId;
        public readonly int? DiskSizeBytes;
        public readonly bool? IsMigrationInProgress;
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskStorageConfig> StorageConfigs;
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskStorageContainer> StorageContainers;

        [OutputConstructor]
        private TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDisk(
            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSource> dataSources,

            string? diskExtId,

            int? diskSizeBytes,

            bool? isMigrationInProgress,

            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskStorageConfig> storageConfigs,

            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskStorageContainer> storageContainers)
        {
            DataSources = dataSources;
            DiskExtId = diskExtId;
            DiskSizeBytes = diskSizeBytes;
            IsMigrationInProgress = isMigrationInProgress;
            StorageConfigs = storageConfigs;
            StorageContainers = storageContainers;
        }
    }
}
