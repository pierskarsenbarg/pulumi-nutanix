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
    public sealed class ClusterV2NetworkSmtpServerServer
    {
        /// <summary>
        /// An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkSmtpServerServerIpAddress> IpAddresses;
        /// <summary>
        /// SMTP server password.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// SMTP port.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// SMTP server user name.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private ClusterV2NetworkSmtpServerServer(
            ImmutableArray<Outputs.ClusterV2NetworkSmtpServerServerIpAddress> ipAddresses,

            string? password,

            int? port,

            string? username)
        {
            IpAddresses = ipAddresses;
            Password = password;
            Port = port;
            Username = username;
        }
    }
}
