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

    public sealed class PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueArgs : global::Pulumi.ResourceArgs
    {
        [Input("keyValuePairs")]
        private InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueKeyValuePairArgs>? _keyValuePairs;
        public InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueKeyValuePairArgs> KeyValuePairs
        {
            get => _keyValuePairs ?? (_keyValuePairs = new InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueKeyValuePairArgs>());
            set => _keyValuePairs = value;
        }

        public PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueArgs()
        {
        }
        public static new PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueArgs Empty => new PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueArgs();
    }
}
