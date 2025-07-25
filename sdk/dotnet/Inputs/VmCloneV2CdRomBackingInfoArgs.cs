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

    public sealed class VmCloneV2CdRomBackingInfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("dataSources")]
        private InputList<Inputs.VmCloneV2CdRomBackingInfoDataSourceArgs>? _dataSources;
        public InputList<Inputs.VmCloneV2CdRomBackingInfoDataSourceArgs> DataSources
        {
            get => _dataSources ?? (_dataSources = new InputList<Inputs.VmCloneV2CdRomBackingInfoDataSourceArgs>());
            set => _dataSources = value;
        }

        [Input("diskExtId")]
        public Input<string>? DiskExtId { get; set; }

        [Input("diskSizeBytes")]
        public Input<int>? DiskSizeBytes { get; set; }

        [Input("isMigrationInProgress")]
        public Input<bool>? IsMigrationInProgress { get; set; }

        [Input("storageConfigs")]
        private InputList<Inputs.VmCloneV2CdRomBackingInfoStorageConfigArgs>? _storageConfigs;
        public InputList<Inputs.VmCloneV2CdRomBackingInfoStorageConfigArgs> StorageConfigs
        {
            get => _storageConfigs ?? (_storageConfigs = new InputList<Inputs.VmCloneV2CdRomBackingInfoStorageConfigArgs>());
            set => _storageConfigs = value;
        }

        [Input("storageContainers")]
        private InputList<Inputs.VmCloneV2CdRomBackingInfoStorageContainerArgs>? _storageContainers;
        public InputList<Inputs.VmCloneV2CdRomBackingInfoStorageContainerArgs> StorageContainers
        {
            get => _storageContainers ?? (_storageContainers = new InputList<Inputs.VmCloneV2CdRomBackingInfoStorageContainerArgs>());
            set => _storageContainers = value;
        }

        public VmCloneV2CdRomBackingInfoArgs()
        {
        }
        public static new VmCloneV2CdRomBackingInfoArgs Empty => new VmCloneV2CdRomBackingInfoArgs();
    }
}
