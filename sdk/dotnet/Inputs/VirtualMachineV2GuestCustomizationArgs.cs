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

    public sealed class VirtualMachineV2GuestCustomizationArgs : global::Pulumi.ResourceArgs
    {
        [Input("configs")]
        private InputList<Inputs.VirtualMachineV2GuestCustomizationConfigArgs>? _configs;

        /// <summary>
        /// The Nutanix Guest Tools customization settings.
        /// 
        /// * `config.sysprep`: Sysprep config
        /// * `config.cloud_init`: CloudInit Config
        /// </summary>
        public InputList<Inputs.VirtualMachineV2GuestCustomizationConfigArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Inputs.VirtualMachineV2GuestCustomizationConfigArgs>());
            set => _configs = value;
        }

        public VirtualMachineV2GuestCustomizationArgs()
        {
        }
        public static new VirtualMachineV2GuestCustomizationArgs Empty => new VirtualMachineV2GuestCustomizationArgs();
    }
}
