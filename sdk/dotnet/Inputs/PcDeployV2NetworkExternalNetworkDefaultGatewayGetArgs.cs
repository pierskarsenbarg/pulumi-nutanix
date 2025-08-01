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

    public sealed class PcDeployV2NetworkExternalNetworkDefaultGatewayGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fqdns")]
        private InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayFqdnGetArgs>? _fqdns;

        /// <summary>
        /// -(Optional) A fully qualified domain name that specifies its exact location in the tree hierarchy of the Domain Name System.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayFqdnGetArgs> Fqdns
        {
            get => _fqdns ?? (_fqdns = new InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayFqdnGetArgs>());
            set => _fqdns = value;
        }

        [Input("ipv4s")]
        private InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv4GetArgs>? _ipv4s;

        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 format.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv4GetArgs> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv4GetArgs>());
            set => _ipv4s = value;
        }

        [Input("ipv6s")]
        private InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv6GetArgs>? _ipv6s;

        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv6 format.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv6GetArgs> Ipv6s
        {
            get => _ipv6s ?? (_ipv6s = new InputList<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayIpv6GetArgs>());
            set => _ipv6s = value;
        }

        public PcDeployV2NetworkExternalNetworkDefaultGatewayGetArgs()
        {
        }
        public static new PcDeployV2NetworkExternalNetworkDefaultGatewayGetArgs Empty => new PcDeployV2NetworkExternalNetworkDefaultGatewayGetArgs();
    }
}
