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

    public sealed class VirtualMachineV2ProtectionPolicyStatePolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        public VirtualMachineV2ProtectionPolicyStatePolicyGetArgs()
        {
        }
        public static new VirtualMachineV2ProtectionPolicyStatePolicyGetArgs Empty => new VirtualMachineV2ProtectionPolicyStatePolicyGetArgs();
    }
}
