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

    public sealed class PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectArgs : global::Pulumi.ResourceArgs
    {
        [Input("destinationPortRanges")]
        private InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectDestinationPortRangeArgs>? _destinationPortRanges;
        public InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectDestinationPortRangeArgs> DestinationPortRanges
        {
            get => _destinationPortRanges ?? (_destinationPortRanges = new InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectDestinationPortRangeArgs>());
            set => _destinationPortRanges = value;
        }

        [Input("sourcePortRanges")]
        private InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectSourcePortRangeArgs>? _sourcePortRanges;
        public InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectSourcePortRangeArgs> SourcePortRanges
        {
            get => _sourcePortRanges ?? (_sourcePortRanges = new InputList<Inputs.PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectSourcePortRangeArgs>());
            set => _sourcePortRanges = value;
        }

        public PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectArgs()
        {
        }
        public static new PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectArgs Empty => new PbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectArgs();
    }
}
