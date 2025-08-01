// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetStorageContainerV2
    {
        /// <summary>
        /// Provides a datasource to Fetch the configuration details of the existing Storage Container identified by the {containerExtId}.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_storage_container = Nutanix.GetStorageContainerV2.Invoke(new()
        ///     {
        ///         ExtId = "1891fd3a-1ef7-4947-af56-9ee4b973c6fd",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetStorageContainerV2Result> InvokeAsync(GetStorageContainerV2Args args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetStorageContainerV2Result>("nutanix:index/getStorageContainerV2:getStorageContainerV2", args ?? new GetStorageContainerV2Args(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to Fetch the configuration details of the existing Storage Container identified by the {containerExtId}.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_storage_container = Nutanix.GetStorageContainerV2.Invoke(new()
        ///     {
        ///         ExtId = "1891fd3a-1ef7-4947-af56-9ee4b973c6fd",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetStorageContainerV2Result> Invoke(GetStorageContainerV2InvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetStorageContainerV2Result>("nutanix:index/getStorageContainerV2:getStorageContainerV2", args ?? new GetStorageContainerV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to Fetch the configuration details of the existing Storage Container identified by the {containerExtId}.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_storage_container = Nutanix.GetStorageContainerV2.Invoke(new()
        ///     {
        ///         ExtId = "1891fd3a-1ef7-4947-af56-9ee4b973c6fd",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetStorageContainerV2Result> Invoke(GetStorageContainerV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetStorageContainerV2Result>("nutanix:index/getStorageContainerV2:getStorageContainerV2", args ?? new GetStorageContainerV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStorageContainerV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// storage container UUID
        /// </summary>
        [Input("extId", required: true)]
        public string ExtId { get; set; } = null!;

        public GetStorageContainerV2Args()
        {
        }
        public static new GetStorageContainerV2Args Empty => new GetStorageContainerV2Args();
    }

    public sealed class GetStorageContainerV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// storage container UUID
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        public GetStorageContainerV2InvokeArgs()
        {
        }
        public static new GetStorageContainerV2InvokeArgs Empty => new GetStorageContainerV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetStorageContainerV2Result
    {
        /// <summary>
        /// - Affinity host extId for RF 1 Storage Container.
        /// </summary>
        public readonly string AffinityHostExtId;
        /// <summary>
        /// - Indicates the current status of Cache Deduplication for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// </summary>
        public readonly string CacheDeduplication;
        /// <summary>
        /// - ext id for the cluster owning the storage container.
        /// </summary>
        public readonly string ClusterExtId;
        /// <summary>
        /// - Corresponding name of the Cluster owning the Storage Container instance.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// - The compression delay in seconds.
        /// </summary>
        public readonly int CompressionDelaySecs;
        /// <summary>
        /// - the storage container ext id
        /// </summary>
        public readonly string ContainerExtId;
        /// <summary>
        /// - Indicates the current status value for Erasure Coding for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// </summary>
        public readonly string ErasureCode;
        /// <summary>
        /// - Delay in performing ErasureCode for the current Container instance.
        /// </summary>
        public readonly int ErasureCodeDelaySecs;
        /// <summary>
        /// - the storage container uuid
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// - Indicates whether to prefer a higher Erasure Code fault domain.
        /// </summary>
        public readonly bool HasHigherEcFaultDomainPreference;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// - Indicates whether the compression is enabled for the Container.
        /// </summary>
        public readonly bool IsCompressionEnabled;
        /// <summary>
        /// - Indicates whether the Container is encrypted or not.
        /// </summary>
        public readonly bool IsEncrypted;
        /// <summary>
        /// - Indicates whether data written to this container should be inline erasure coded or not. This field is only considered when ErasureCoding is enabled.
        /// </summary>
        public readonly bool IsInlineEcEnabled;
        /// <summary>
        /// - Indicates whether the Container is internal and is managed by Nutanix.
        /// </summary>
        public readonly bool IsInternal;
        /// <summary>
        /// - Indicates if the Storage Container is marked for removal. This field is set when the Storage Container is about to be destroyed.
        /// </summary>
        public readonly bool IsMarkedForRemoval;
        /// <summary>
        /// - Indicates whether the NFS whitelist is inherited from global config.
        /// </summary>
        public readonly bool IsNfsWhitelistInherited;
        /// <summary>
        /// - Indicates whether the Container instance has software encryption enabled.
        /// </summary>
        public readonly bool IsSoftwareEncryptionEnabled;
        /// <summary>
        /// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStorageContainerV2LinkResult> Links;
        /// <summary>
        /// - Max capacity of the Container as defined by the user.
        /// </summary>
        public readonly int LogicalAdvertisedCapacityBytes;
        /// <summary>
        /// - Total reserved size (in bytes) of the container (set by Admin). This also accounts for the container's replication factor. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity.
        /// </summary>
        public readonly int LogicalExplicitReservedCapacityBytes;
        /// <summary>
        /// - This is the summation of reservations provisioned on all vdisks in the container. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity
        /// </summary>
        public readonly int LogicalImplicitReservedCapacityBytes;
        /// <summary>
        /// - Maximum physical capacity of the Storage Container in bytes.
        /// </summary>
        public readonly int MaxCapacityBytes;
        /// <summary>
        /// Name of the storage container.  Note that the name of Storage Container should be unique per cluster.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// - List of NFS addresses which need to be whitelisted.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStorageContainerV2NfsWhitelistAddressResult> NfsWhitelistAddresses;
        /// <summary>
        /// - Indicates the current status of Disk Deduplication for the Container. available values:  `NONE`,    `OFF`,    `POST_PROCESS`
        /// </summary>
        public readonly string OnDiskDedup;
        /// <summary>
        /// - owner ext id
        /// </summary>
        public readonly string OwnerExtId;
        /// <summary>
        /// - Replication factor of the Storage Container.
        /// </summary>
        public readonly int ReplicationFactor;
        /// <summary>
        /// - extId of the Storage Pool owning the Storage Container instance.
        /// </summary>
        public readonly string StoragePoolExtId;
        /// <summary>
        /// - A globally unique identifier that represents the tenant that owns this entity.
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetStorageContainerV2Result(
            string affinityHostExtId,

            string cacheDeduplication,

            string clusterExtId,

            string clusterName,

            int compressionDelaySecs,

            string containerExtId,

            string erasureCode,

            int erasureCodeDelaySecs,

            string extId,

            bool hasHigherEcFaultDomainPreference,

            string id,

            bool isCompressionEnabled,

            bool isEncrypted,

            bool isInlineEcEnabled,

            bool isInternal,

            bool isMarkedForRemoval,

            bool isNfsWhitelistInherited,

            bool isSoftwareEncryptionEnabled,

            ImmutableArray<Outputs.GetStorageContainerV2LinkResult> links,

            int logicalAdvertisedCapacityBytes,

            int logicalExplicitReservedCapacityBytes,

            int logicalImplicitReservedCapacityBytes,

            int maxCapacityBytes,

            string name,

            ImmutableArray<Outputs.GetStorageContainerV2NfsWhitelistAddressResult> nfsWhitelistAddresses,

            string onDiskDedup,

            string ownerExtId,

            int replicationFactor,

            string storagePoolExtId,

            string tenantId)
        {
            AffinityHostExtId = affinityHostExtId;
            CacheDeduplication = cacheDeduplication;
            ClusterExtId = clusterExtId;
            ClusterName = clusterName;
            CompressionDelaySecs = compressionDelaySecs;
            ContainerExtId = containerExtId;
            ErasureCode = erasureCode;
            ErasureCodeDelaySecs = erasureCodeDelaySecs;
            ExtId = extId;
            HasHigherEcFaultDomainPreference = hasHigherEcFaultDomainPreference;
            Id = id;
            IsCompressionEnabled = isCompressionEnabled;
            IsEncrypted = isEncrypted;
            IsInlineEcEnabled = isInlineEcEnabled;
            IsInternal = isInternal;
            IsMarkedForRemoval = isMarkedForRemoval;
            IsNfsWhitelistInherited = isNfsWhitelistInherited;
            IsSoftwareEncryptionEnabled = isSoftwareEncryptionEnabled;
            Links = links;
            LogicalAdvertisedCapacityBytes = logicalAdvertisedCapacityBytes;
            LogicalExplicitReservedCapacityBytes = logicalExplicitReservedCapacityBytes;
            LogicalImplicitReservedCapacityBytes = logicalImplicitReservedCapacityBytes;
            MaxCapacityBytes = maxCapacityBytes;
            Name = name;
            NfsWhitelistAddresses = nfsWhitelistAddresses;
            OnDiskDedup = onDiskDedup;
            OwnerExtId = ownerExtId;
            ReplicationFactor = replicationFactor;
            StoragePoolExtId = storagePoolExtId;
            TenantId = tenantId;
        }
    }
}
