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

    public sealed class VirtualMachineV2CdRomArgs : global::Pulumi.ResourceArgs
    {
        [Input("backingInfos")]
        private InputList<Inputs.VirtualMachineV2CdRomBackingInfoArgs>? _backingInfos;

        /// <summary>
        /// Storage provided by Nutanix ADSF
        /// </summary>
        public InputList<Inputs.VirtualMachineV2CdRomBackingInfoArgs> BackingInfos
        {
            get => _backingInfos ?? (_backingInfos = new InputList<Inputs.VirtualMachineV2CdRomBackingInfoArgs>());
            set => _backingInfos = value;
        }

        [Input("diskAddresses")]
        private InputList<Inputs.VirtualMachineV2CdRomDiskAddressArgs>? _diskAddresses;

        /// <summary>
        /// Virtual Machine disk (VM disk).
        /// </summary>
        public InputList<Inputs.VirtualMachineV2CdRomDiskAddressArgs> DiskAddresses
        {
            get => _diskAddresses ?? (_diskAddresses = new InputList<Inputs.VirtualMachineV2CdRomDiskAddressArgs>());
            set => _diskAddresses = value;
        }

        /// <summary>
        /// A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        /// <summary>
        /// Type of ISO image inserted in CD-ROM. Valid values "OTHER", "GUEST_TOOLS", "GUEST_CUSTOMIZATION" .
        /// </summary>
        [Input("isoType")]
        public Input<string>? IsoType { get; set; }

        public VirtualMachineV2CdRomArgs()
        {
        }
        public static new VirtualMachineV2CdRomArgs Empty => new VirtualMachineV2CdRomArgs();
    }
}
