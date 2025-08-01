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

    public sealed class PcRestoreV2DomainManagerConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) Bootstrap configuration details for the domain manager (Prism Central).
        /// </summary>
        [Input("bootstrapConfig")]
        public Input<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigArgs>? BootstrapConfig { get; set; }

        /// <summary>
        /// -(Required) Currently representing the build information to be used for the cluster creation.
        /// </summary>
        [Input("buildInfo", required: true)]
        public Input<Inputs.PcRestoreV2DomainManagerConfigBuildInfoArgs> BuildInfo { get; set; } = null!;

        [Input("credentials")]
        private InputList<Inputs.PcRestoreV2DomainManagerConfigCredentialArgs>? _credentials;

        /// <summary>
        /// - (Optional) The credentials consist of a username and password for a particular user like admin. Users can pass the credentials of admin users currently which will be configured in the create domain manager operation.
        /// </summary>
        public InputList<Inputs.PcRestoreV2DomainManagerConfigCredentialArgs> Credentials
        {
            get => _credentials ?? (_credentials = new InputList<Inputs.PcRestoreV2DomainManagerConfigCredentialArgs>());
            set => _credentials = value;
        }

        /// <summary>
        /// -(Required) Name of the domain manager (Prism Central).
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("resourceConfigs")]
        private InputList<Inputs.PcRestoreV2DomainManagerConfigResourceConfigArgs>? _resourceConfigs;

        /// <summary>
        /// -(Optional) This configuration is used to provide the resource-related details like container external identifiers, number of VCPUs, memory size, data disk size of the domain manager (Prism Central). In the case of a multi-node setup, the sum of resources like number of VCPUs, memory size and data disk size are provided.
        /// </summary>
        public InputList<Inputs.PcRestoreV2DomainManagerConfigResourceConfigArgs> ResourceConfigs
        {
            get => _resourceConfigs ?? (_resourceConfigs = new InputList<Inputs.PcRestoreV2DomainManagerConfigResourceConfigArgs>());
            set => _resourceConfigs = value;
        }

        /// <summary>
        /// -(Optional) A boolean value indicating whether to enable lockdown mode for a cluster.
        /// </summary>
        [Input("shouldEnableLockdownMode")]
        public Input<bool>? ShouldEnableLockdownMode { get; set; }

        /// <summary>
        /// - (Required) Domain manager (Prism Central) size is an enumeration of starter, small, large, or extra large starter values. The allowed values are:
        /// - `SMALL` : Domain manager (Prism Central) of size small.
        /// - `LARGE` : Domain manager (Prism Central) of size large.
        /// - `EXTRALARGE` : Domain manager (Prism Central) of size extra large.
        /// - `STARTER` : Domain manager (Prism Central) of size starter.
        /// </summary>
        [Input("size", required: true)]
        public Input<string> Size { get; set; } = null!;

        public PcRestoreV2DomainManagerConfigArgs()
        {
        }
        public static new PcRestoreV2DomainManagerConfigArgs Empty => new PcRestoreV2DomainManagerConfigArgs();
    }
}
