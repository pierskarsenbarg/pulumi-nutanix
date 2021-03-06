// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class FoundationIpmiConfigBlockNodeGetArgs : Pulumi.ResourceArgs
    {
        [Input("ipmiConfigureNow", required: true)]
        public Input<bool> IpmiConfigureNow { get; set; } = null!;

        [Input("ipmiConfigureSuccessful")]
        public Input<bool>? IpmiConfigureSuccessful { get; set; }

        [Input("ipmiIp", required: true)]
        public Input<string> IpmiIp { get; set; } = null!;

        [Input("ipmiMac", required: true)]
        public Input<string> IpmiMac { get; set; } = null!;

        [Input("ipmiMessage")]
        public Input<string>? IpmiMessage { get; set; }

        public FoundationIpmiConfigBlockNodeGetArgs()
        {
        }
    }
}
