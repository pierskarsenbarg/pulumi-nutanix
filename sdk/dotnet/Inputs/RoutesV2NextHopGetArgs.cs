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

    public sealed class RoutesV2NextHopGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("nextHopIpAddresses")]
        private InputList<Inputs.RoutesV2NextHopNextHopIpAddressGetArgs>? _nextHopIpAddresses;
        public InputList<Inputs.RoutesV2NextHopNextHopIpAddressGetArgs> NextHopIpAddresses
        {
            get => _nextHopIpAddresses ?? (_nextHopIpAddresses = new InputList<Inputs.RoutesV2NextHopNextHopIpAddressGetArgs>());
            set => _nextHopIpAddresses = value;
        }

        [Input("nextHopName")]
        public Input<string>? NextHopName { get; set; }

        [Input("nextHopReference")]
        public Input<string>? NextHopReference { get; set; }

        [Input("nextHopType", required: true)]
        public Input<string> NextHopType { get; set; } = null!;

        public RoutesV2NextHopGetArgs()
        {
        }
        public static new RoutesV2NextHopGetArgs Empty => new RoutesV2NextHopGetArgs();
    }
}
