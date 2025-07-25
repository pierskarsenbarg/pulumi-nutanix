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
    public sealed class GetClusterV2NetworkManagementServerResult
    {
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterV2NetworkManagementServerIpResult> Ips;
        /// <summary>
        /// - Indicates whether it is DRS enabled or not.
        /// </summary>
        public readonly bool IsDrsEnabled;
        /// <summary>
        /// - Indicates whether the host is managed by an entity or not.
        /// </summary>
        public readonly bool IsInUse;
        /// <summary>
        /// - Indicates whether it is registered or not.
        /// </summary>
        public readonly bool IsRegistered;
        /// <summary>
        /// - Type of management server.
        /// Valid values are:
        /// - "VCENTER"   	Vcenter management server.
        /// </summary>
        public readonly bool Type;

        [OutputConstructor]
        private GetClusterV2NetworkManagementServerResult(
            ImmutableArray<Outputs.GetClusterV2NetworkManagementServerIpResult> ips,

            bool isDrsEnabled,

            bool isInUse,

            bool isRegistered,

            bool type)
        {
            Ips = ips;
            IsDrsEnabled = isDrsEnabled;
            IsInUse = isInUse;
            IsRegistered = isRegistered;
            Type = type;
        }
    }
}
