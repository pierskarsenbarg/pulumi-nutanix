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
    public static class GetStorageContainersV2
    {
        /// <summary>
        /// Provides a datasource to Lists the Storage Containers present in the system.
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
        ///     var storage_containers = Nutanix.GetStorageContainersV2.Invoke();
        /// 
        /// });
        /// ```
        /// 
        /// ## Storage Container
        /// 
        /// The `storage_containers` contains list of Storage Container objects. Each Storage Container object contains the following attributes:
        /// 
        /// * `ext_id`: - the storage container uuid
        /// * `tenant_id`: - A globally unique identifier that represents the tenant that owns this entity.
        /// * `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// 
        /// * `container_ext_id`: - the storage container ext id
        /// * `owner_ext_id`: - owner ext id
        /// * `name`: Name of the storage container.  Note that the name of Storage Container should be unique per cluster.
        /// * `cluster_ext_id`: - ext id for the cluster owning the storage container.
        /// * `storage_pool_ext_id`: - extId of the Storage Pool owning the Storage Container instance.
        /// * `is_marked_for_removal`: - Indicates if the Storage Container is marked for removal. This field is set when the Storage Container is about to be destroyed.
        /// * `max_capacity_bytes`: - Maximum physical capacity of the Storage Container in bytes.
        /// * `logical_explicit_reserved_capacity_bytes`: - Total reserved size (in bytes) of the container (set by Admin). This also accounts for the container's replication factor. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity.
        /// * `logical_implicit_reserved_capacity_bytes`: - This is the summation of reservations provisioned on all VDisks in the container. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity
        /// * `logical_advertised_capacity_bytes`: - Max capacity of the Container as defined by the user.
        /// * `replication_factor`: - Replication factor of the Storage Container.
        /// * `nfs_whitelist_addresses`: - List of NFS addresses which need to be whitelisted.
        /// * `is_nfs_whitelist_inherited`: - Indicates whether the NFS whitelist is inherited from global config.
        /// * `erasure_code`: - Indicates the current status value for Erasure Coding for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// 
        /// * `is_inline_ec_enabled`: - Indicates whether data written to this container should be inline erasure coded or not. This field is only considered when ErasureCoding is enabled.
        /// * `has_higher_ec_fault_domain_preference`: - Indicates whether to prefer a higher Erasure Code fault domain.
        /// * `erasure_code_delay_secs`: - Delay in performing ErasureCode for the current Container instance.
        /// * `cache_deduplication`: - Indicates the current status of Cache Deduplication for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// * `on_disk_dedup`: - Indicates the current status of Disk Deduplication for the Container. available values:  `NONE`,    `OFF`,    `POST_PROCESS`
        /// * `is_compression_enabled`: - Indicates whether the compression is enabled for the Container.
        /// * `compression_delay_secs`: - The compression delay in seconds.
        /// * `is_internal`: - Indicates whether the Container is internal and is managed by Nutanix.
        /// * `is_software_encryption_enabled`: - Indicates whether the Container instance has software encryption enabled.
        /// * `is_encrypted`: - Indicates whether the Container is encrypted or not.
        /// * `affinity_host_ext_id`: - Affinity host extId for RF 1 Storage Container.
        /// * `cluster_name`: - Corresponding name of the Cluster owning the Storage Container instance.
        /// 
        /// 
        /// ### nfs_whitelist_addresses
        /// 
        /// * `ipv4`: Reference to address configuration
        /// * `ipv6`: Reference to address configuration
        /// * `fqdn`: Reference to address configuration
        /// 
        /// ### ipv4, ipv6 (Reference to address configuration)
        /// 
        /// * `value`: value of address
        /// * `prefix_length`: The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// 
        /// ### fqdn (Reference to address configuration)
        /// 
        /// * `value`: value of fqdn address
        /// 
        /// 
        /// 
        /// See detailed information in [Nutanix List Storage Containers v4](https://developers.nutanix.com/api-reference?namespace=clustermgmt&amp;version=v4.0#tag/StorageContainers/operation/listStorageContainers).
        /// </summary>
        public static Task<GetStorageContainersV2Result> InvokeAsync(GetStorageContainersV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetStorageContainersV2Result>("nutanix:index/getStorageContainersV2:getStorageContainersV2", args ?? new GetStorageContainersV2Args(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to Lists the Storage Containers present in the system.
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
        ///     var storage_containers = Nutanix.GetStorageContainersV2.Invoke();
        /// 
        /// });
        /// ```
        /// 
        /// ## Storage Container
        /// 
        /// The `storage_containers` contains list of Storage Container objects. Each Storage Container object contains the following attributes:
        /// 
        /// * `ext_id`: - the storage container uuid
        /// * `tenant_id`: - A globally unique identifier that represents the tenant that owns this entity.
        /// * `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// 
        /// * `container_ext_id`: - the storage container ext id
        /// * `owner_ext_id`: - owner ext id
        /// * `name`: Name of the storage container.  Note that the name of Storage Container should be unique per cluster.
        /// * `cluster_ext_id`: - ext id for the cluster owning the storage container.
        /// * `storage_pool_ext_id`: - extId of the Storage Pool owning the Storage Container instance.
        /// * `is_marked_for_removal`: - Indicates if the Storage Container is marked for removal. This field is set when the Storage Container is about to be destroyed.
        /// * `max_capacity_bytes`: - Maximum physical capacity of the Storage Container in bytes.
        /// * `logical_explicit_reserved_capacity_bytes`: - Total reserved size (in bytes) of the container (set by Admin). This also accounts for the container's replication factor. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity.
        /// * `logical_implicit_reserved_capacity_bytes`: - This is the summation of reservations provisioned on all VDisks in the container. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity
        /// * `logical_advertised_capacity_bytes`: - Max capacity of the Container as defined by the user.
        /// * `replication_factor`: - Replication factor of the Storage Container.
        /// * `nfs_whitelist_addresses`: - List of NFS addresses which need to be whitelisted.
        /// * `is_nfs_whitelist_inherited`: - Indicates whether the NFS whitelist is inherited from global config.
        /// * `erasure_code`: - Indicates the current status value for Erasure Coding for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// 
        /// * `is_inline_ec_enabled`: - Indicates whether data written to this container should be inline erasure coded or not. This field is only considered when ErasureCoding is enabled.
        /// * `has_higher_ec_fault_domain_preference`: - Indicates whether to prefer a higher Erasure Code fault domain.
        /// * `erasure_code_delay_secs`: - Delay in performing ErasureCode for the current Container instance.
        /// * `cache_deduplication`: - Indicates the current status of Cache Deduplication for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// * `on_disk_dedup`: - Indicates the current status of Disk Deduplication for the Container. available values:  `NONE`,    `OFF`,    `POST_PROCESS`
        /// * `is_compression_enabled`: - Indicates whether the compression is enabled for the Container.
        /// * `compression_delay_secs`: - The compression delay in seconds.
        /// * `is_internal`: - Indicates whether the Container is internal and is managed by Nutanix.
        /// * `is_software_encryption_enabled`: - Indicates whether the Container instance has software encryption enabled.
        /// * `is_encrypted`: - Indicates whether the Container is encrypted or not.
        /// * `affinity_host_ext_id`: - Affinity host extId for RF 1 Storage Container.
        /// * `cluster_name`: - Corresponding name of the Cluster owning the Storage Container instance.
        /// 
        /// 
        /// ### nfs_whitelist_addresses
        /// 
        /// * `ipv4`: Reference to address configuration
        /// * `ipv6`: Reference to address configuration
        /// * `fqdn`: Reference to address configuration
        /// 
        /// ### ipv4, ipv6 (Reference to address configuration)
        /// 
        /// * `value`: value of address
        /// * `prefix_length`: The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// 
        /// ### fqdn (Reference to address configuration)
        /// 
        /// * `value`: value of fqdn address
        /// 
        /// 
        /// 
        /// See detailed information in [Nutanix List Storage Containers v4](https://developers.nutanix.com/api-reference?namespace=clustermgmt&amp;version=v4.0#tag/StorageContainers/operation/listStorageContainers).
        /// </summary>
        public static Output<GetStorageContainersV2Result> Invoke(GetStorageContainersV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetStorageContainersV2Result>("nutanix:index/getStorageContainersV2:getStorageContainersV2", args ?? new GetStorageContainersV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to Lists the Storage Containers present in the system.
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
        ///     var storage_containers = Nutanix.GetStorageContainersV2.Invoke();
        /// 
        /// });
        /// ```
        /// 
        /// ## Storage Container
        /// 
        /// The `storage_containers` contains list of Storage Container objects. Each Storage Container object contains the following attributes:
        /// 
        /// * `ext_id`: - the storage container uuid
        /// * `tenant_id`: - A globally unique identifier that represents the tenant that owns this entity.
        /// * `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// 
        /// * `container_ext_id`: - the storage container ext id
        /// * `owner_ext_id`: - owner ext id
        /// * `name`: Name of the storage container.  Note that the name of Storage Container should be unique per cluster.
        /// * `cluster_ext_id`: - ext id for the cluster owning the storage container.
        /// * `storage_pool_ext_id`: - extId of the Storage Pool owning the Storage Container instance.
        /// * `is_marked_for_removal`: - Indicates if the Storage Container is marked for removal. This field is set when the Storage Container is about to be destroyed.
        /// * `max_capacity_bytes`: - Maximum physical capacity of the Storage Container in bytes.
        /// * `logical_explicit_reserved_capacity_bytes`: - Total reserved size (in bytes) of the container (set by Admin). This also accounts for the container's replication factor. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity.
        /// * `logical_implicit_reserved_capacity_bytes`: - This is the summation of reservations provisioned on all VDisks in the container. The actual reserved capacity of the container will be the maximum of explicitReservedCapacity and implicitReservedCapacity
        /// * `logical_advertised_capacity_bytes`: - Max capacity of the Container as defined by the user.
        /// * `replication_factor`: - Replication factor of the Storage Container.
        /// * `nfs_whitelist_addresses`: - List of NFS addresses which need to be whitelisted.
        /// * `is_nfs_whitelist_inherited`: - Indicates whether the NFS whitelist is inherited from global config.
        /// * `erasure_code`: - Indicates the current status value for Erasure Coding for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// 
        /// * `is_inline_ec_enabled`: - Indicates whether data written to this container should be inline erasure coded or not. This field is only considered when ErasureCoding is enabled.
        /// * `has_higher_ec_fault_domain_preference`: - Indicates whether to prefer a higher Erasure Code fault domain.
        /// * `erasure_code_delay_secs`: - Delay in performing ErasureCode for the current Container instance.
        /// * `cache_deduplication`: - Indicates the current status of Cache Deduplication for the Container. available values:  `NONE`,    `OFF`,    `ON`
        /// * `on_disk_dedup`: - Indicates the current status of Disk Deduplication for the Container. available values:  `NONE`,    `OFF`,    `POST_PROCESS`
        /// * `is_compression_enabled`: - Indicates whether the compression is enabled for the Container.
        /// * `compression_delay_secs`: - The compression delay in seconds.
        /// * `is_internal`: - Indicates whether the Container is internal and is managed by Nutanix.
        /// * `is_software_encryption_enabled`: - Indicates whether the Container instance has software encryption enabled.
        /// * `is_encrypted`: - Indicates whether the Container is encrypted or not.
        /// * `affinity_host_ext_id`: - Affinity host extId for RF 1 Storage Container.
        /// * `cluster_name`: - Corresponding name of the Cluster owning the Storage Container instance.
        /// 
        /// 
        /// ### nfs_whitelist_addresses
        /// 
        /// * `ipv4`: Reference to address configuration
        /// * `ipv6`: Reference to address configuration
        /// * `fqdn`: Reference to address configuration
        /// 
        /// ### ipv4, ipv6 (Reference to address configuration)
        /// 
        /// * `value`: value of address
        /// * `prefix_length`: The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// 
        /// ### fqdn (Reference to address configuration)
        /// 
        /// * `value`: value of fqdn address
        /// 
        /// 
        /// 
        /// See detailed information in [Nutanix List Storage Containers v4](https://developers.nutanix.com/api-reference?namespace=clustermgmt&amp;version=v4.0#tag/StorageContainers/operation/listStorageContainers).
        /// </summary>
        public static Output<GetStorageContainersV2Result> Invoke(GetStorageContainersV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetStorageContainersV2Result>("nutanix:index/getStorageContainersV2:getStorageContainersV2", args ?? new GetStorageContainersV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStorageContainersV2Args : global::Pulumi.InvokeArgs
    {
        [Input("apply")]
        public string? Apply { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources.
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default.
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
        /// </summary>
        [Input("select")]
        public string? Select { get; set; }

        public GetStorageContainersV2Args()
        {
        }
        public static new GetStorageContainersV2Args Empty => new GetStorageContainersV2Args();
    }

    public sealed class GetStorageContainersV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("apply")]
        public Input<string>? Apply { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources.
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default.
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
        /// </summary>
        [Input("select")]
        public Input<string>? Select { get; set; }

        public GetStorageContainersV2InvokeArgs()
        {
        }
        public static new GetStorageContainersV2InvokeArgs Empty => new GetStorageContainersV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetStorageContainersV2Result
    {
        public readonly string? Apply;
        public readonly string? Filter;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly string? OrderBy;
        public readonly int? Page;
        public readonly string? Select;
        /// <summary>
        /// Lists the Storage Containers present in the system.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStorageContainersV2StorageContainerResult> StorageContainers;

        [OutputConstructor]
        private GetStorageContainersV2Result(
            string? apply,

            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select,

            ImmutableArray<Outputs.GetStorageContainersV2StorageContainerResult> storageContainers)
        {
            Apply = apply;
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
            StorageContainers = storageContainers;
        }
    }
}
