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
    public sealed class GetProtectionPolicyV2ReplicationLocationReplicationSubLocationResult
    {
        /// <summary>
        /// - External identifier of the clusters.
        /// </summary>
        public readonly Outputs.GetProtectionPolicyV2ReplicationLocationReplicationSubLocationClusterExtIdsResult ClusterExtIds;

        [OutputConstructor]
        private GetProtectionPolicyV2ReplicationLocationReplicationSubLocationResult(Outputs.GetProtectionPolicyV2ReplicationLocationReplicationSubLocationClusterExtIdsResult clusterExtIds)
        {
            ClusterExtIds = clusterExtIds;
        }
    }
}
