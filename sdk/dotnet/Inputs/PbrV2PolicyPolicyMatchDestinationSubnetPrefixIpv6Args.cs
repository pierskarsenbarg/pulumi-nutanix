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

    public sealed class PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6Args : global::Pulumi.ResourceArgs
    {
        [Input("ips")]
        private InputList<Inputs.PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6IpArgs>? _ips;
        public InputList<Inputs.PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6IpArgs> Ips
        {
            get => _ips ?? (_ips = new InputList<Inputs.PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6IpArgs>());
            set => _ips = value;
        }

        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        public PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6Args()
        {
        }
        public static new PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6Args Empty => new PbrV2PolicyPolicyMatchDestinationSubnetPrefixIpv6Args();
    }
}
