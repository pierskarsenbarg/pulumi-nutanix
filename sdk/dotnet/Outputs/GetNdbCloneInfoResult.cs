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
    public sealed class GetNdbCloneInfoResult
    {
        public readonly ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigResult> BpgConfigs;
        public readonly ImmutableDictionary<string, string> SecureInfo;

        [OutputConstructor]
        private GetNdbCloneInfoResult(
            ImmutableArray<Outputs.GetNdbCloneInfoBpgConfigResult> bpgConfigs,

            ImmutableDictionary<string, string> secureInfo)
        {
            BpgConfigs = bpgConfigs;
            SecureInfo = secureInfo;
        }
    }
}
