// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class PcRegistrationV2ConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootstrapConfigs")]
        private InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigArgs>? _bootstrapConfigs;
        public InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigArgs> BootstrapConfigs
        {
            get => _bootstrapConfigs ?? (_bootstrapConfigs = new InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigArgs>());
            set => _bootstrapConfigs = value;
        }

        [Input("buildInfos")]
        private InputList<Inputs.PcRegistrationV2ConfigBuildInfoArgs>? _buildInfos;
        public InputList<Inputs.PcRegistrationV2ConfigBuildInfoArgs> BuildInfos
        {
            get => _buildInfos ?? (_buildInfos = new InputList<Inputs.PcRegistrationV2ConfigBuildInfoArgs>());
            set => _buildInfos = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("resourceConfigs")]
        private InputList<Inputs.PcRegistrationV2ConfigResourceConfigArgs>? _resourceConfigs;
        public InputList<Inputs.PcRegistrationV2ConfigResourceConfigArgs> ResourceConfigs
        {
            get => _resourceConfigs ?? (_resourceConfigs = new InputList<Inputs.PcRegistrationV2ConfigResourceConfigArgs>());
            set => _resourceConfigs = value;
        }

        [Input("shouldEnableLockdownMode")]
        public Input<bool>? ShouldEnableLockdownMode { get; set; }

        [Input("size")]
        public Input<string>? Size { get; set; }

        public PcRegistrationV2ConfigArgs()
        {
        }
        public static new PcRegistrationV2ConfigArgs Empty => new PcRegistrationV2ConfigArgs();
    }
}
