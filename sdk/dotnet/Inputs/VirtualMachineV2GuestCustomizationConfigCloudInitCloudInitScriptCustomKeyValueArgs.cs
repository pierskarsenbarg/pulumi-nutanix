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

    public sealed class VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs : global::Pulumi.ResourceArgs
    {
        [Input("keyValuePairs")]
        private InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs>? _keyValuePairs;
        public InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs> KeyValuePairs
        {
            get => _keyValuePairs ?? (_keyValuePairs = new InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairArgs>());
            set => _keyValuePairs = value;
        }

        public VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs()
        {
        }
        public static new VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs Empty => new VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueArgs();
    }
}
