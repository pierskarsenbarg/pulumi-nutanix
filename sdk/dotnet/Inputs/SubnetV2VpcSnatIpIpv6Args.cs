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

    public sealed class SubnetV2VpcSnatIpIpv6Args : global::Pulumi.ResourceArgs
    {
        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public SubnetV2VpcSnatIpIpv6Args()
        {
        }
        public static new SubnetV2VpcSnatIpIpv6Args Empty => new SubnetV2VpcSnatIpIpv6Args();
    }
}
