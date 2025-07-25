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
    public sealed class VirtualMachineV2GuestCustomization
    {
        /// <summary>
        /// The Nutanix Guest Tools customization settings.
        /// 
        /// * `config.sysprep`: Sysprep config
        /// * `config.cloud_init`: CloudInit Config
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineV2GuestCustomizationConfig> Configs;

        [OutputConstructor]
        private VirtualMachineV2GuestCustomization(ImmutableArray<Outputs.VirtualMachineV2GuestCustomizationConfig> configs)
        {
            Configs = configs;
        }
    }
}
