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

    public sealed class PbrProtocolParametersIcmpGetArgs : Pulumi.ResourceArgs
    {
        [Input("icmpCode", required: true)]
        public Input<int> IcmpCode { get; set; } = null!;

        [Input("icmpType", required: true)]
        public Input<int> IcmpType { get; set; } = null!;

        public PbrProtocolParametersIcmpGetArgs()
        {
        }
    }
}