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

    public sealed class SubnetV2VpcExternallyRoutablePrefixIpv4Args : global::Pulumi.ResourceArgs
    {
        [Input("ips")]
        private InputList<Inputs.SubnetV2VpcExternallyRoutablePrefixIpv4IpArgs>? _ips;
        public InputList<Inputs.SubnetV2VpcExternallyRoutablePrefixIpv4IpArgs> Ips
        {
            get => _ips ?? (_ips = new InputList<Inputs.SubnetV2VpcExternallyRoutablePrefixIpv4IpArgs>());
            set => _ips = value;
        }

        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        public SubnetV2VpcExternallyRoutablePrefixIpv4Args()
        {
        }
        public static new SubnetV2VpcExternallyRoutablePrefixIpv4Args Empty => new SubnetV2VpcExternallyRoutablePrefixIpv4Args();
    }
}
