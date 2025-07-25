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

    public sealed class VmCloneV2GuestCustomizationConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInits")]
        private InputList<Inputs.VmCloneV2GuestCustomizationConfigCloudInitArgs>? _cloudInits;
        public InputList<Inputs.VmCloneV2GuestCustomizationConfigCloudInitArgs> CloudInits
        {
            get => _cloudInits ?? (_cloudInits = new InputList<Inputs.VmCloneV2GuestCustomizationConfigCloudInitArgs>());
            set => _cloudInits = value;
        }

        [Input("syspreps")]
        private InputList<Inputs.VmCloneV2GuestCustomizationConfigSysprepArgs>? _syspreps;
        public InputList<Inputs.VmCloneV2GuestCustomizationConfigSysprepArgs> Syspreps
        {
            get => _syspreps ?? (_syspreps = new InputList<Inputs.VmCloneV2GuestCustomizationConfigSysprepArgs>());
            set => _syspreps = value;
        }

        public VmCloneV2GuestCustomizationConfigArgs()
        {
        }
        public static new VmCloneV2GuestCustomizationConfigArgs Empty => new VmCloneV2GuestCustomizationConfigArgs();
    }
}
