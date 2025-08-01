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

    public sealed class PcRegistrationV2ConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootstrapConfig")]
        public Input<Inputs.PcRegistrationV2ConfigBootstrapConfigGetArgs>? BootstrapConfig { get; set; }

        [Input("buildInfo", required: true)]
        public Input<Inputs.PcRegistrationV2ConfigBuildInfoGetArgs> BuildInfo { get; set; } = null!;

        [Input("credentials")]
        private InputList<Inputs.PcRegistrationV2ConfigCredentialGetArgs>? _credentials;

        /// <summary>
        /// -(Required)  Credentials to connect to a remote cluster.
        /// </summary>
        public InputList<Inputs.PcRegistrationV2ConfigCredentialGetArgs> Credentials
        {
            get => _credentials ?? (_credentials = new InputList<Inputs.PcRegistrationV2ConfigCredentialGetArgs>());
            set => _credentials = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("resourceConfigs")]
        private InputList<Inputs.PcRegistrationV2ConfigResourceConfigGetArgs>? _resourceConfigs;
        public InputList<Inputs.PcRegistrationV2ConfigResourceConfigGetArgs> ResourceConfigs
        {
            get => _resourceConfigs ?? (_resourceConfigs = new InputList<Inputs.PcRegistrationV2ConfigResourceConfigGetArgs>());
            set => _resourceConfigs = value;
        }

        [Input("shouldEnableLockdownMode")]
        public Input<bool>? ShouldEnableLockdownMode { get; set; }

        [Input("size", required: true)]
        public Input<string> Size { get; set; } = null!;

        public PcRegistrationV2ConfigGetArgs()
        {
        }
        public static new PcRegistrationV2ConfigGetArgs Empty => new PcRegistrationV2ConfigGetArgs();
    }
}
