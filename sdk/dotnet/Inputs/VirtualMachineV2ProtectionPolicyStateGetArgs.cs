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

    public sealed class VirtualMachineV2ProtectionPolicyStateGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("policies")]
        private InputList<Inputs.VirtualMachineV2ProtectionPolicyStatePolicyGetArgs>? _policies;

        /// <summary>
        /// Reference to the policy object in use.
        /// * `policy.ext_id`: (Optional) Reference to the policy object in use.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2ProtectionPolicyStatePolicyGetArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.VirtualMachineV2ProtectionPolicyStatePolicyGetArgs>());
            set => _policies = value;
        }

        public VirtualMachineV2ProtectionPolicyStateGetArgs()
        {
        }
        public static new VirtualMachineV2ProtectionPolicyStateGetArgs Empty => new VirtualMachineV2ProtectionPolicyStateGetArgs();
    }
}
