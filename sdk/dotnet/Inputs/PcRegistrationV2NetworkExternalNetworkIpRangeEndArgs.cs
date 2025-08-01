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

    public sealed class PcRegistrationV2NetworkExternalNetworkIpRangeEndArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4s")]
        private InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv4Args>? _ipv4s;

        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 format.
        /// </summary>
        public InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv4Args> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv4Args>());
            set => _ipv4s = value;
        }

        [Input("ipv6s")]
        private InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv6Args>? _ipv6s;

        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv6 format.
        /// </summary>
        public InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv6Args> Ipv6s
        {
            get => _ipv6s ?? (_ipv6s = new InputList<Inputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv6Args>());
            set => _ipv6s = value;
        }

        public PcRegistrationV2NetworkExternalNetworkIpRangeEndArgs()
        {
        }
        public static new PcRegistrationV2NetworkExternalNetworkIpRangeEndArgs Empty => new PcRegistrationV2NetworkExternalNetworkIpRangeEndArgs();
    }
}
