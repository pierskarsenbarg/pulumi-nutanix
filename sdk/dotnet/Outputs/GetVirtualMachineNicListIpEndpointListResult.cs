// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetVirtualMachineNicListIpEndpointListResult
    {
        public readonly string Ip;
        public readonly string Type;

        [OutputConstructor]
        private GetVirtualMachineNicListIpEndpointListResult(
            string ip,

            string type)
        {
            Ip = ip;
            Type = type;
        }
    }
}