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
    public sealed class GetVirtualMachinesV2VmGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueResult
    {
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairResult> KeyValuePairs;

        [OutputConstructor]
        private GetVirtualMachinesV2VmGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueResult(ImmutableArray<Outputs.GetVirtualMachinesV2VmGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairResult> keyValuePairs)
        {
            KeyValuePairs = keyValuePairs;
        }
    }
}
