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
    public static class GetLcmEntitiesV2
    {
        /// <summary>
        /// Get details about all LCM entities.
        /// 
        /// 
        /// ## Example
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var entities = Nutanix.GetLcmEntityV2.Invoke();
        /// 
        ///     var lcm_entities_filtered = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Filter = "entityModel eq 'Calm Policy Engine'",
        ///     });
        /// 
        ///     var lcm_entities_limit = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Limit = 5,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetLcmEntitiesV2Result> InvokeAsync(GetLcmEntitiesV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLcmEntitiesV2Result>("nutanix:index/getLcmEntitiesV2:getLcmEntitiesV2", args ?? new GetLcmEntitiesV2Args(), options.WithDefaults());

        /// <summary>
        /// Get details about all LCM entities.
        /// 
        /// 
        /// ## Example
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var entities = Nutanix.GetLcmEntityV2.Invoke();
        /// 
        ///     var lcm_entities_filtered = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Filter = "entityModel eq 'Calm Policy Engine'",
        ///     });
        /// 
        ///     var lcm_entities_limit = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Limit = 5,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetLcmEntitiesV2Result> Invoke(GetLcmEntitiesV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLcmEntitiesV2Result>("nutanix:index/getLcmEntitiesV2:getLcmEntitiesV2", args ?? new GetLcmEntitiesV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Get details about all LCM entities.
        /// 
        /// 
        /// ## Example
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var entities = Nutanix.GetLcmEntityV2.Invoke();
        /// 
        ///     var lcm_entities_filtered = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Filter = "entityModel eq 'Calm Policy Engine'",
        ///     });
        /// 
        ///     var lcm_entities_limit = Nutanix.GetLcmEntitiesV2.Invoke(new()
        ///     {
        ///         Limit = 5,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetLcmEntitiesV2Result> Invoke(GetLcmEntitiesV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetLcmEntitiesV2Result>("nutanix:index/getLcmEntitiesV2:getLcmEntitiesV2", args ?? new GetLcmEntitiesV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLcmEntitiesV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields: clientName, createdBy, extId, createdTime, displayName, extId, isSystemDefined, lastUpdatedTime.
        /// * The filter can be applied to the following fields:
        /// * `clusterExtId`
        /// * `entityClass`
        /// * `entityModel`
        /// * `entityType`
        /// * `entityVersion`
        /// * `hardwareVendor`
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// - A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. following fields: accessibleClients, accessibleEntityTypes, assignedUserGroupsCount, assignedUsersCount, clientName, createdBy, createdTime, description, displayName, extId, isSystemDefined, lastUpdatedTime, links, operations, tenantId.
        /// * The select can be applied to the following fields:
        /// * `entityClass`
        /// * `entityModel`
        /// * `entityType`
        /// * `entityVersion`
        /// * `hardwareVendor`
        /// </summary>
        [Input("select")]
        public string? Select { get; set; }

        public GetLcmEntitiesV2Args()
        {
        }
        public static new GetLcmEntitiesV2Args Empty => new GetLcmEntitiesV2Args();
    }

    public sealed class GetLcmEntitiesV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields: clientName, createdBy, extId, createdTime, displayName, extId, isSystemDefined, lastUpdatedTime.
        /// * The filter can be applied to the following fields:
        /// * `clusterExtId`
        /// * `entityClass`
        /// * `entityModel`
        /// * `entityType`
        /// * `entityVersion`
        /// * `hardwareVendor`
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// - A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. following fields: accessibleClients, accessibleEntityTypes, assignedUserGroupsCount, assignedUsersCount, clientName, createdBy, createdTime, description, displayName, extId, isSystemDefined, lastUpdatedTime, links, operations, tenantId.
        /// * The select can be applied to the following fields:
        /// * `entityClass`
        /// * `entityModel`
        /// * `entityType`
        /// * `entityVersion`
        /// * `hardwareVendor`
        /// </summary>
        [Input("select")]
        public Input<string>? Select { get; set; }

        public GetLcmEntitiesV2InvokeArgs()
        {
        }
        public static new GetLcmEntitiesV2InvokeArgs Empty => new GetLcmEntitiesV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetLcmEntitiesV2Result
    {
        /// <summary>
        /// List of LCM entities.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLcmEntitiesV2EntityResult> Entities;
        public readonly string? Filter;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly string? OrderBy;
        public readonly int? Page;
        public readonly string? Select;

        [OutputConstructor]
        private GetLcmEntitiesV2Result(
            ImmutableArray<Outputs.GetLcmEntitiesV2EntityResult> entities,

            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select)
        {
            Entities = entities;
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
        }
    }
}
