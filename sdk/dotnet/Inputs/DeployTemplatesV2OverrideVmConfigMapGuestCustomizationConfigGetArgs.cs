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

    public sealed class DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInits")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitGetArgs>? _cloudInits;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitGetArgs> CloudInits
        {
            get => _cloudInits ?? (_cloudInits = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigCloudInitGetArgs>());
            set => _cloudInits = value;
        }

        [Input("syspreps")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepGetArgs>? _syspreps;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepGetArgs> Syspreps
        {
            get => _syspreps ?? (_syspreps = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepGetArgs>());
            set => _syspreps = value;
        }

        public DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs()
        {
        }
        public static new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs Empty => new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs();
    }
}
