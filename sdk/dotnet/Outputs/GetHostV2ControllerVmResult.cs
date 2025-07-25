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
    public sealed class GetHostV2ControllerVmResult
    {
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostV2ControllerVmBackplaneAddressResult> BackplaneAddresses;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostV2ControllerVmExternalAddressResult> ExternalAddresses;
        /// <summary>
        /// - Controller VM Id.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// - Maintenance mode status.
        /// </summary>
        public readonly bool MaintenanceMode;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostV2ControllerVmNatIpResult> NatIps;
        /// <summary>
        /// - NAT port.
        /// </summary>
        public readonly int NatPort;
        /// <summary>
        /// - RDMA backplane address.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostV2ControllerVmRdmaBackplaneAddressResult> RdmaBackplaneAddresses;

        [OutputConstructor]
        private GetHostV2ControllerVmResult(
            ImmutableArray<Outputs.GetHostV2ControllerVmBackplaneAddressResult> backplaneAddresses,

            ImmutableArray<Outputs.GetHostV2ControllerVmExternalAddressResult> externalAddresses,

            int id,

            bool maintenanceMode,

            ImmutableArray<Outputs.GetHostV2ControllerVmNatIpResult> natIps,

            int natPort,

            ImmutableArray<Outputs.GetHostV2ControllerVmRdmaBackplaneAddressResult> rdmaBackplaneAddresses)
        {
            BackplaneAddresses = backplaneAddresses;
            ExternalAddresses = externalAddresses;
            Id = id;
            MaintenanceMode = maintenanceMode;
            NatIps = natIps;
            NatPort = natPort;
            RdmaBackplaneAddresses = rdmaBackplaneAddresses;
        }
    }
}
