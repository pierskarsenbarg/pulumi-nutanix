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
    public sealed class GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptResult
    {
        /// <summary>
        /// The list of the individual KeyValuePair elements.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueResult> CustomKeyValues;
        /// <summary>
        /// xml object
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptUnattendXmlResult> UnattendXmls;

        [OutputConstructor]
        private GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptResult(
            ImmutableArray<Outputs.GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueResult> customKeyValues,

            ImmutableArray<Outputs.GetVirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptUnattendXmlResult> unattendXmls)
        {
            CustomKeyValues = customKeyValues;
            UnattendXmls = unattendXmls;
        }
    }
}
