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
    public sealed class PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScript
    {
        public readonly ImmutableArray<Outputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValue> CustomKeyValues;
        public readonly ImmutableArray<Outputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptUserData> UserDatas;

        [OutputConstructor]
        private PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScript(
            ImmutableArray<Outputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValue> customKeyValues,

            ImmutableArray<Outputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptUserData> userDatas)
        {
            CustomKeyValues = customKeyValues;
            UserDatas = userDatas;
        }
    }
}
