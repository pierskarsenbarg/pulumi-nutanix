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
    public static class GetServiceGroupsV2
    {
        /// <summary>
        /// List all the service Groups.
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
        ///     var serviceGroup = Nutanix.GetServiceGroupsV2.Invoke();
        /// 
        ///     var serviceGroupFiltered = Nutanix.GetServiceGroupsV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'service_group_name'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetServiceGroupsV2Result> InvokeAsync(GetServiceGroupsV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetServiceGroupsV2Result>("nutanix:index/getServiceGroupsV2:getServiceGroupsV2", args ?? new GetServiceGroupsV2Args(), options.WithDefaults());

        /// <summary>
        /// List all the service Groups.
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
        ///     var serviceGroup = Nutanix.GetServiceGroupsV2.Invoke();
        /// 
        ///     var serviceGroupFiltered = Nutanix.GetServiceGroupsV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'service_group_name'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetServiceGroupsV2Result> Invoke(GetServiceGroupsV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetServiceGroupsV2Result>("nutanix:index/getServiceGroupsV2:getServiceGroupsV2", args ?? new GetServiceGroupsV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// List all the service Groups.
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
        ///     var serviceGroup = Nutanix.GetServiceGroupsV2.Invoke();
        /// 
        ///     var serviceGroupFiltered = Nutanix.GetServiceGroupsV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'service_group_name'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetServiceGroupsV2Result> Invoke(GetServiceGroupsV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetServiceGroupsV2Result>("nutanix:index/getServiceGroupsV2:getServiceGroupsV2", args ?? new GetServiceGroupsV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServiceGroupsV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The filter can be applied to the following fields:
        /// - `createdBy`
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. The orderby can be applied to the following fields:
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. The select can be applied to the following fields:
        /// - `createdBy`
        /// </summary>
        [Input("select")]
        public string? Select { get; set; }

        public GetServiceGroupsV2Args()
        {
        }
        public static new GetServiceGroupsV2Args Empty => new GetServiceGroupsV2Args();
    }

    public sealed class GetServiceGroupsV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The filter can be applied to the following fields:
        /// - `createdBy`
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. The orderby can be applied to the following fields:
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. The select can be applied to the following fields:
        /// - `createdBy`
        /// </summary>
        [Input("select")]
        public Input<string>? Select { get; set; }

        public GetServiceGroupsV2InvokeArgs()
        {
        }
        public static new GetServiceGroupsV2InvokeArgs Empty => new GetServiceGroupsV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetServiceGroupsV2Result
    {
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
        /// List of service groups
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceGroupsV2ServiceGroupResult> ServiceGroups;

        [OutputConstructor]
        private GetServiceGroupsV2Result(
            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select,

            ImmutableArray<Outputs.GetServiceGroupsV2ServiceGroupResult> serviceGroups)
        {
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
            ServiceGroups = serviceGroups;
        }
    }
}
