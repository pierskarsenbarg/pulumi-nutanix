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
    public sealed class GetPbrStatusResourceProtocolParameterResult
    {
        public readonly ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterIcmpResult> Icmps;
        public readonly int ProtocolNumber;
        public readonly ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterTcpResult> Tcps;
        public readonly ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterUdpResult> Udps;

        [OutputConstructor]
        private GetPbrStatusResourceProtocolParameterResult(
            ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterIcmpResult> icmps,

            int protocolNumber,

            ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterTcpResult> tcps,

            ImmutableArray<Outputs.GetPbrStatusResourceProtocolParameterUdpResult> udps)
        {
            Icmps = icmps;
            ProtocolNumber = protocolNumber;
            Tcps = tcps;
            Udps = udps;
        }
    }
}