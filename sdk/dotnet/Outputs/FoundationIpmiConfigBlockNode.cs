// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class FoundationIpmiConfigBlockNode
    {
        /// <summary>
        /// - (Required) Whether IPMI should be configured. Should be kept true to configure
        /// </summary>
        public readonly bool IpmiConfigureNow;
        /// <summary>
        /// - Whether IPMI was successfully configured.
        /// </summary>
        public readonly bool? IpmiConfigureSuccessful;
        /// <summary>
        /// - IPMI IP address.
        /// </summary>
        public readonly string IpmiIp;
        /// <summary>
        /// - (Required) IPMI mac address.
        /// </summary>
        public readonly string IpmiMac;
        /// <summary>
        /// - IPMI configuration status message if any.
        /// </summary>
        public readonly string? IpmiMessage;

        [OutputConstructor]
        private FoundationIpmiConfigBlockNode(
            bool ipmiConfigureNow,

            bool? ipmiConfigureSuccessful,

            string ipmiIp,

            string ipmiMac,

            string? ipmiMessage)
        {
            IpmiConfigureNow = ipmiConfigureNow;
            IpmiConfigureSuccessful = ipmiConfigureSuccessful;
            IpmiIp = ipmiIp;
            IpmiMac = ipmiMac;
            IpmiMessage = ipmiMessage;
        }
    }
}
