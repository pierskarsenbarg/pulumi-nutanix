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
    public sealed class GetPcRestorePointsV2RestorePointDomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueKeyValuePairValueMapOfStringResult
    {
        public readonly ImmutableDictionary<string, string> Map;

        [OutputConstructor]
        private GetPcRestorePointsV2RestorePointDomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueKeyValuePairValueMapOfStringResult(ImmutableDictionary<string, string> map)
        {
            Map = map;
        }
    }
}
