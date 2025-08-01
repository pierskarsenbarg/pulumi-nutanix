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

    public sealed class VpcV2ExternalSubnetExternalIpArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4s")]
        private InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv4Args>? _ipv4s;

        /// <summary>
        /// Reference to address configuration
        /// </summary>
        public InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv4Args> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv4Args>());
            set => _ipv4s = value;
        }

        [Input("ipv6s")]
        private InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv6Args>? _ipv6s;

        /// <summary>
        /// Reference to address configuration
        /// </summary>
        public InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv6Args> Ipv6s
        {
            get => _ipv6s ?? (_ipv6s = new InputList<Inputs.VpcV2ExternalSubnetExternalIpIpv6Args>());
            set => _ipv6s = value;
        }

        public VpcV2ExternalSubnetExternalIpArgs()
        {
        }
        public static new VpcV2ExternalSubnetExternalIpArgs Empty => new VpcV2ExternalSubnetExternalIpArgs();
    }
}
