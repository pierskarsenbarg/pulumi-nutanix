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

    public sealed class SubnetV2IpUsageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipPoolUsages")]
        private InputList<Inputs.SubnetV2IpUsageIpPoolUsageGetArgs>? _ipPoolUsages;
        public InputList<Inputs.SubnetV2IpUsageIpPoolUsageGetArgs> IpPoolUsages
        {
            get => _ipPoolUsages ?? (_ipPoolUsages = new InputList<Inputs.SubnetV2IpUsageIpPoolUsageGetArgs>());
            set => _ipPoolUsages = value;
        }

        [Input("numAssignedIps")]
        public Input<int>? NumAssignedIps { get; set; }

        [Input("numFreeIps")]
        public Input<int>? NumFreeIps { get; set; }

        [Input("numMacs")]
        public Input<int>? NumMacs { get; set; }

        public SubnetV2IpUsageGetArgs()
        {
        }
        public static new SubnetV2IpUsageGetArgs Empty => new SubnetV2IpUsageGetArgs();
    }
}
