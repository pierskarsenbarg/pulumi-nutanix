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
    public sealed class GetNdbNetworkAvailableIpsAvailableIpResult
    {
        /// <summary>
        /// cluster id
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// cluster name
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// network profile id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// list of available ips in network
        /// </summary>
        public readonly ImmutableArray<string> IpAddresses;
        /// <summary>
        /// managed by ndb or not
        /// </summary>
        public readonly bool Managed;
        /// <summary>
        /// Network Name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// property name of vlan
        /// </summary>
        public readonly string PropertyName;
        /// <summary>
        /// type of network
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetNdbNetworkAvailableIpsAvailableIpResult(
            string clusterId,

            string clusterName,

            string id,

            ImmutableArray<string> ipAddresses,

            bool managed,

            string name,

            string propertyName,

            string type)
        {
            ClusterId = clusterId;
            ClusterName = clusterName;
            Id = id;
            IpAddresses = ipAddresses;
            Managed = managed;
            Name = name;
            PropertyName = propertyName;
            Type = type;
        }
    }
}