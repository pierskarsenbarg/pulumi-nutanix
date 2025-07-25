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

    public sealed class PbrV2PolicyPolicyMatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("destinations", required: true)]
        private InputList<Inputs.PbrV2PolicyPolicyMatchDestinationArgs>? _destinations;
        public InputList<Inputs.PbrV2PolicyPolicyMatchDestinationArgs> Destinations
        {
            get => _destinations ?? (_destinations = new InputList<Inputs.PbrV2PolicyPolicyMatchDestinationArgs>());
            set => _destinations = value;
        }

        [Input("protocolParameters")]
        private InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterArgs>? _protocolParameters;
        public InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterArgs> ProtocolParameters
        {
            get => _protocolParameters ?? (_protocolParameters = new InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterArgs>());
            set => _protocolParameters = value;
        }

        [Input("protocolType", required: true)]
        public Input<string> ProtocolType { get; set; } = null!;

        [Input("sources", required: true)]
        private InputList<Inputs.PbrV2PolicyPolicyMatchSourceArgs>? _sources;
        public InputList<Inputs.PbrV2PolicyPolicyMatchSourceArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.PbrV2PolicyPolicyMatchSourceArgs>());
            set => _sources = value;
        }

        public PbrV2PolicyPolicyMatchArgs()
        {
        }
        public static new PbrV2PolicyPolicyMatchArgs Empty => new PbrV2PolicyPolicyMatchArgs();
    }
}
