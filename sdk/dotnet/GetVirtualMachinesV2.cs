// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetVirtualMachinesV2
    {
        /// <summary>
        /// Lists the Virtual Machines defined on the system. List of Virtual Machines can be further filtered out using various filtering options.
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
        ///     var vms = Nutanix.GetVirtualMachinesV2.Invoke();
        /// 
        ///     var vms_1 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Limit = 2,
        ///         Page = 0,
        ///     });
        /// 
        ///     var vms_2 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'test-vm-filter'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetVirtualMachinesV2Result> InvokeAsync(GetVirtualMachinesV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachinesV2Result>("nutanix:index/getVirtualMachinesV2:getVirtualMachinesV2", args ?? new GetVirtualMachinesV2Args(), options.WithDefaults());

        /// <summary>
        /// Lists the Virtual Machines defined on the system. List of Virtual Machines can be further filtered out using various filtering options.
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
        ///     var vms = Nutanix.GetVirtualMachinesV2.Invoke();
        /// 
        ///     var vms_1 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Limit = 2,
        ///         Page = 0,
        ///     });
        /// 
        ///     var vms_2 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'test-vm-filter'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetVirtualMachinesV2Result> Invoke(GetVirtualMachinesV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVirtualMachinesV2Result>("nutanix:index/getVirtualMachinesV2:getVirtualMachinesV2", args ?? new GetVirtualMachinesV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Lists the Virtual Machines defined on the system. List of Virtual Machines can be further filtered out using various filtering options.
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
        ///     var vms = Nutanix.GetVirtualMachinesV2.Invoke();
        /// 
        ///     var vms_1 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Limit = 2,
        ///         Page = 0,
        ///     });
        /// 
        ///     var vms_2 = Nutanix.GetVirtualMachinesV2.Invoke(new()
        ///     {
        ///         Filter = "name eq 'test-vm-filter'",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetVirtualMachinesV2Result> Invoke(GetVirtualMachinesV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetVirtualMachinesV2Result>("nutanix:index/getVirtualMachinesV2:getVirtualMachinesV2", args ?? new GetVirtualMachinesV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualMachinesV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
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

        public GetVirtualMachinesV2Args()
        {
        }
        public static new GetVirtualMachinesV2Args Empty => new GetVirtualMachinesV2Args();
    }

    public sealed class GetVirtualMachinesV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
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

        public GetVirtualMachinesV2InvokeArgs()
        {
        }
        public static new GetVirtualMachinesV2InvokeArgs Empty => new GetVirtualMachinesV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetVirtualMachinesV2Result
    {
        /// <summary>
        /// A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
        /// </summary>
        public readonly string? Filter;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        public readonly int? Limit;
        /// <summary>
        /// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
        /// </summary>
        public readonly string? OrderBy;
        /// <summary>
        /// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        public readonly int? Page;
        /// <summary>
        /// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
        /// </summary>
        public readonly string? Select;
        /// <summary>
        /// List of all vms
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmResult> Vms;

        [OutputConstructor]
        private GetVirtualMachinesV2Result(
            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select,

            ImmutableArray<Outputs.GetVirtualMachinesV2VmResult> vms)
        {
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
            Vms = vms;
        }
    }
}
