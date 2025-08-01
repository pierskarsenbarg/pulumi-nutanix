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
    public static class GetRouteTablesV2
    {
        /// <summary>
        /// Provides Nutanix datasource to List route tables.
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
        ///     var all_tables = Nutanix.GetRouteTablesV2.Invoke();
        /// 
        ///     var route_tables_with_filter = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         Filter = "vpcReference eq 'f4b4b3b4-4b4b-4b4b-4b4b-4b4b4b4b4b4b'",
        ///     });
        /// 
        ///     var route_tables_with_orderby = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         OrderBy = "vpcReference",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetRouteTablesV2Result> InvokeAsync(GetRouteTablesV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRouteTablesV2Result>("nutanix:index/getRouteTablesV2:getRouteTablesV2", args ?? new GetRouteTablesV2Args(), options.WithDefaults());

        /// <summary>
        /// Provides Nutanix datasource to List route tables.
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
        ///     var all_tables = Nutanix.GetRouteTablesV2.Invoke();
        /// 
        ///     var route_tables_with_filter = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         Filter = "vpcReference eq 'f4b4b3b4-4b4b-4b4b-4b4b-4b4b4b4b4b4b'",
        ///     });
        /// 
        ///     var route_tables_with_orderby = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         OrderBy = "vpcReference",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetRouteTablesV2Result> Invoke(GetRouteTablesV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRouteTablesV2Result>("nutanix:index/getRouteTablesV2:getRouteTablesV2", args ?? new GetRouteTablesV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides Nutanix datasource to List route tables.
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
        ///     var all_tables = Nutanix.GetRouteTablesV2.Invoke();
        /// 
        ///     var route_tables_with_filter = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         Filter = "vpcReference eq 'f4b4b3b4-4b4b-4b4b-4b4b-4b4b4b4b4b4b'",
        ///     });
        /// 
        ///     var route_tables_with_orderby = Nutanix.GetRouteTablesV2.Invoke(new()
        ///     {
        ///         OrderBy = "vpcReference",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetRouteTablesV2Result> Invoke(GetRouteTablesV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetRouteTablesV2Result>("nutanix:index/getRouteTablesV2:getRouteTablesV2", args ?? new GetRouteTablesV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRouteTablesV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources.
        /// * The filter can be applied to the following fields:
        /// * `externalRoutingDomainReference`
        /// * `vpcReference`
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
        /// * The orderby can be applied to the following fields:
        /// * `vpcReference`
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        public GetRouteTablesV2Args()
        {
        }
        public static new GetRouteTablesV2Args Empty => new GetRouteTablesV2Args();
    }

    public sealed class GetRouteTablesV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources.
        /// * The filter can be applied to the following fields:
        /// * `externalRoutingDomainReference`
        /// * `vpcReference`
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
        /// * The orderby can be applied to the following fields:
        /// * `vpcReference`
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        public GetRouteTablesV2InvokeArgs()
        {
        }
        public static new GetRouteTablesV2InvokeArgs Empty => new GetRouteTablesV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetRouteTablesV2Result
    {
        public readonly string? Filter;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly string? OrderBy;
        public readonly int? Page;
        /// <summary>
        /// A list of route tables.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRouteTablesV2RouteTableResult> RouteTables;

        [OutputConstructor]
        private GetRouteTablesV2Result(
            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            ImmutableArray<Outputs.GetRouteTablesV2RouteTableResult> routeTables)
        {
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            RouteTables = routeTables;
        }
    }
}
