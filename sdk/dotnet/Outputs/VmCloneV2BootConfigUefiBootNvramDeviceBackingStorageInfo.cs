// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfo
    {
        public readonly ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSource> DataSources;
        public readonly int? DiskSizeBytes;
        public readonly ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoStorageConfig> StorageConfigs;
        public readonly ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoStorageContainer> StorageContainers;

        [OutputConstructor]
        private VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfo(
            ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSource> dataSources,

            int? diskSizeBytes,

            ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoStorageConfig> storageConfigs,

            ImmutableArray<Outputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoStorageContainer> storageContainers)
        {
            DataSources = dataSources;
            DiskSizeBytes = diskSizeBytes;
            StorageConfigs = storageConfigs;
            StorageContainers = storageContainers;
        }
    }
}
