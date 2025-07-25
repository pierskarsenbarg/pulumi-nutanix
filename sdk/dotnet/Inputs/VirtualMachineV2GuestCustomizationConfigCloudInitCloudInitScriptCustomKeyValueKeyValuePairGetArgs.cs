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

    public sealed class VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// VM name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("values")]
        private InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairValueGetArgs>? _values;
        public InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairValueGetArgs> Values
        {
            get => _values ?? (_values = new InputList<Inputs.VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairValueGetArgs>());
            set => _values = value;
        }

        public VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairGetArgs()
        {
        }
        public static new VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairGetArgs Empty => new VirtualMachineV2GuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairGetArgs();
    }
}
