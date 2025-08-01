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

    public sealed class VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("boolean")]
        public Input<bool>? Boolean { get; set; }

        [Input("integer")]
        public Input<int>? Integer { get; set; }

        [Input("integerLists")]
        private InputList<int>? _integerLists;
        public InputList<int> IntegerLists
        {
            get => _integerLists ?? (_integerLists = new InputList<int>());
            set => _integerLists = value;
        }

        [Input("mapOfStrings")]
        private InputList<Inputs.VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueMapOfStringGetArgs>? _mapOfStrings;
        public InputList<Inputs.VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueMapOfStringGetArgs> MapOfStrings
        {
            get => _mapOfStrings ?? (_mapOfStrings = new InputList<Inputs.VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueMapOfStringGetArgs>());
            set => _mapOfStrings = value;
        }

        [Input("object")]
        private InputMap<string>? _object;
        public InputMap<string> Object
        {
            get => _object ?? (_object = new InputMap<string>());
            set => _object = value;
        }

        [Input("string")]
        public Input<string>? String { get; set; }

        [Input("stringLists")]
        private InputList<string>? _stringLists;
        public InputList<string> StringLists
        {
            get => _stringLists ?? (_stringLists = new InputList<string>());
            set => _stringLists = value;
        }

        public VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueGetArgs()
        {
        }
        public static new VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueGetArgs Empty => new VirtualMachineV2GuestCustomizationConfigSysprepSysprepScriptCustomKeyValueKeyValuePairValueGetArgs();
    }
}
