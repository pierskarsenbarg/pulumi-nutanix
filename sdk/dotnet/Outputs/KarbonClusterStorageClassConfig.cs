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
    public sealed class KarbonClusterStorageClassConfig
    {
        /// <summary>
        /// - (Required) The name of the storage class.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Reclaim policy for persistent volumes provisioned using the specified storage class.
        /// * `volumes_config.#.file_system` - (Optional) Karbon uses either the ext4 or xfs file-system on the volume disk.
        /// * `volumes_config.#.flash_mode` - (Optional) Pins the persistent volumes to the flash tier in case of a `true` value.
        /// * `volumes_config.#.password` - (Required) The password of the Prism Element user that the API calls use to provision volumes.
        /// * `volumes_config.#.prism_element_cluster_uuid` - (Required) The universally unique identifier (UUID) of the Prism Element cluster.
        /// * `volumes_config.#.storage_container` - (Required) Name of the storage container the storage container uses to provision volumes.
        /// * `volumes_config.#.username` - (Required) Username of the Prism Element user that the API calls use to provision volumes.
        /// 
        /// **Note:** Updates to this attribute forces new resource creation.
        /// </summary>
        public readonly string? ReclaimPolicy;
        public readonly Outputs.KarbonClusterStorageClassConfigVolumesConfig VolumesConfig;

        [OutputConstructor]
        private KarbonClusterStorageClassConfig(
            string? name,

            string? reclaimPolicy,

            Outputs.KarbonClusterStorageClassConfigVolumesConfig volumesConfig)
        {
            Name = name;
            ReclaimPolicy = reclaimPolicy;
            VolumesConfig = volumesConfig;
        }
    }
}
