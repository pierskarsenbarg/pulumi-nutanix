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

    public sealed class DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs : global::Pulumi.ResourceArgs
    {
        [Input("keyValuePairs")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs>? _keyValuePairs;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs> KeyValuePairs
        {
            get => _keyValuePairs ?? (_keyValuePairs = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs>());
            set => _keyValuePairs = value;
        }

        public DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs()
        {
        }
        public static new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs Empty => new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs();
    }
}
