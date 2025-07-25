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
    public sealed class PcBackupTargetV2Location
    {
        /// <summary>
        /// -(Optional) A boolean value indicating whether to enable lockdown mode for a cluster.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcBackupTargetV2LocationClusterLocation> ClusterLocations;
        /// <summary>
        /// -(Optional) Currently representing the build information to be used for the cluster creation.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcBackupTargetV2LocationObjectStoreLocation> ObjectStoreLocations;

        [OutputConstructor]
        private PcBackupTargetV2Location(
            ImmutableArray<Outputs.PcBackupTargetV2LocationClusterLocation> clusterLocations,

            ImmutableArray<Outputs.PcBackupTargetV2LocationObjectStoreLocation> objectStoreLocations)
        {
            ClusterLocations = clusterLocations;
            ObjectStoreLocations = objectStoreLocations;
        }
    }
}
