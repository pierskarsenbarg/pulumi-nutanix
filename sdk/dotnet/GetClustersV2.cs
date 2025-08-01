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
    public static class GetClustersV2
    {
        /// <summary>
        /// Lists all cluster entities registered to Prism Central.
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
        ///     var cls = Nutanix.GetClustersV2.Invoke();
        /// 
        ///     var filtered_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'cluster-1'",
        ///     });
        /// 
        ///     var paged_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Limit = 10,
        ///         Page = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetClustersV2Result> InvokeAsync(GetClustersV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClustersV2Result>("nutanix:index/getClustersV2:getClustersV2", args ?? new GetClustersV2Args(), options.WithDefaults());

        /// <summary>
        /// Lists all cluster entities registered to Prism Central.
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
        ///     var cls = Nutanix.GetClustersV2.Invoke();
        /// 
        ///     var filtered_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'cluster-1'",
        ///     });
        /// 
        ///     var paged_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Limit = 10,
        ///         Page = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetClustersV2Result> Invoke(GetClustersV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClustersV2Result>("nutanix:index/getClustersV2:getClustersV2", args ?? new GetClustersV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Lists all cluster entities registered to Prism Central.
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
        ///     var cls = Nutanix.GetClustersV2.Invoke();
        /// 
        ///     var filtered_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'cluster-1'",
        ///     });
        /// 
        ///     var paged_cls = Nutanix.GetClustersV2.Invoke(new()
        ///     {
        ///         Limit = 10,
        ///         Page = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetClustersV2Result> Invoke(GetClustersV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetClustersV2Result>("nutanix:index/getClustersV2:getClustersV2", args ?? new GetClustersV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClustersV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify a sequence of transformations to the entity set, such as groupby, filter, aggregate etc. As of now only support for groupby exists.For example '\$apply=groupby((templateName))' would get all templates grouped by templateName.
        /// The apply can be applied on the following fields:
        /// - config/buildInfo/version
        /// - nodes/numberOfNodes
        /// </summary>
        [Input("apply")]
        public string? Apply { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby.
        /// The `expand` can be applied on the following fields:
        /// - clusterProfile
        /// - storageSummary
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'.
        /// The filter can be applied to the following fields:
        /// - backupEligibilityScore
        /// - clusterProfileExtId
        /// - config/buildInfo/version
        /// - config/clusterFunction
        /// - config/encryptionInTransitStatus
        /// - config/encryptionOption
        /// - config/encryptionScope
        /// - config/hypervisorTypes
        /// - config/isAvailable
        /// - extId
        /// - name
        /// - network/keyManagementServerType
        /// - upgradeStatus
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order.
        /// The orderby can be applied to the following fields:
        /// - backupEligibilityScore
        /// - config/buildInfo/version
        /// - config/isAvailable
        /// - extId
        /// - inefficientVmCount
        /// - name
        /// - network/keyManagementServerType
        /// - nodes/numberOfNodes
        /// - upgradeStatus
        /// - vmCount
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned.
        /// The select  can be applied to the following fields:
        /// - backupEligibilityScore
        /// - inefficientVmCount
        /// - name
        /// - upgradeStatus
        /// - vmCount
        /// </summary>
        [Input("select")]
        public string? Select { get; set; }

        public GetClustersV2Args()
        {
        }
        public static new GetClustersV2Args Empty => new GetClustersV2Args();
    }

    public sealed class GetClustersV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify a sequence of transformations to the entity set, such as groupby, filter, aggregate etc. As of now only support for groupby exists.For example '\$apply=groupby((templateName))' would get all templates grouped by templateName.
        /// The apply can be applied on the following fields:
        /// - config/buildInfo/version
        /// - nodes/numberOfNodes
        /// </summary>
        [Input("apply")]
        public Input<string>? Apply { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby.
        /// The `expand` can be applied on the following fields:
        /// - clusterProfile
        /// - storageSummary
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'.
        /// The filter can be applied to the following fields:
        /// - backupEligibilityScore
        /// - clusterProfileExtId
        /// - config/buildInfo/version
        /// - config/clusterFunction
        /// - config/encryptionInTransitStatus
        /// - config/encryptionOption
        /// - config/encryptionScope
        /// - config/hypervisorTypes
        /// - config/isAvailable
        /// - extId
        /// - name
        /// - network/keyManagementServerType
        /// - upgradeStatus
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order.
        /// The orderby can be applied to the following fields:
        /// - backupEligibilityScore
        /// - config/buildInfo/version
        /// - config/isAvailable
        /// - extId
        /// - inefficientVmCount
        /// - name
        /// - network/keyManagementServerType
        /// - nodes/numberOfNodes
        /// - upgradeStatus
        /// - vmCount
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned.
        /// The select  can be applied to the following fields:
        /// - backupEligibilityScore
        /// - inefficientVmCount
        /// - name
        /// - upgradeStatus
        /// - vmCount
        /// </summary>
        [Input("select")]
        public Input<string>? Select { get; set; }

        public GetClustersV2InvokeArgs()
        {
        }
        public static new GetClustersV2InvokeArgs Empty => new GetClustersV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetClustersV2Result
    {
        public readonly string? Apply;
        /// <summary>
        /// - List of cluster entities.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClustersV2ClusterEntityResult> ClusterEntities;
        public readonly string? Expand;
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
        private GetClustersV2Result(
            string? apply,

            ImmutableArray<Outputs.GetClustersV2ClusterEntityResult> clusterEntities,

            string? expand,

            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select)
        {
            Apply = apply;
            ClusterEntities = clusterEntities;
            Expand = expand;
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
        }
    }
}
