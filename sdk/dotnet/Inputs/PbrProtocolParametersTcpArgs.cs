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

    public sealed class PbrProtocolParametersTcpArgs : global::Pulumi.ResourceArgs
    {
        [Input("destinationPortRangeLists")]
        private InputList<Inputs.PbrProtocolParametersTcpDestinationPortRangeListArgs>? _destinationPortRangeLists;
        public InputList<Inputs.PbrProtocolParametersTcpDestinationPortRangeListArgs> DestinationPortRangeLists
        {
            get => _destinationPortRangeLists ?? (_destinationPortRangeLists = new InputList<Inputs.PbrProtocolParametersTcpDestinationPortRangeListArgs>());
            set => _destinationPortRangeLists = value;
        }

        [Input("sourcePortRangeLists")]
        private InputList<Inputs.PbrProtocolParametersTcpSourcePortRangeListArgs>? _sourcePortRangeLists;
        public InputList<Inputs.PbrProtocolParametersTcpSourcePortRangeListArgs> SourcePortRangeLists
        {
            get => _sourcePortRangeLists ?? (_sourcePortRangeLists = new InputList<Inputs.PbrProtocolParametersTcpSourcePortRangeListArgs>());
            set => _sourcePortRangeLists = value;
        }

        public PbrProtocolParametersTcpArgs()
        {
        }
        public static new PbrProtocolParametersTcpArgs Empty => new PbrProtocolParametersTcpArgs();
    }
}
