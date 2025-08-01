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
    public sealed class StaticRoutesStaticRoutesList
    {
        /// <summary>
        /// Destination ip with prefix.
        /// </summary>
        public readonly string Destination;
        /// <summary>
        /// Reference to a subnet. Supported with 2022.x .
        /// </summary>
        public readonly string? ExternalSubnetReferenceUuid;
        /// <summary>
        /// Reference to a vpn connection.
        /// </summary>
        public readonly string? VpnConnectionReferenceUuid;

        [OutputConstructor]
        private StaticRoutesStaticRoutesList(
            string destination,

            string? externalSubnetReferenceUuid,

            string? vpnConnectionReferenceUuid)
        {
            Destination = destination;
            ExternalSubnetReferenceUuid = externalSubnetReferenceUuid;
            VpnConnectionReferenceUuid = vpnConnectionReferenceUuid;
        }
    }
}
