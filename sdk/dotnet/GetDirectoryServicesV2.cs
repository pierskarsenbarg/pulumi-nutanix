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
    public static class GetDirectoryServicesV2
    {
        /// <summary>
        /// Provides a datasource to retrieve all Directory Service(s).
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
        ///     var example = Nutanix.GetDirectoryServicesV2.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetDirectoryServicesV2Result> InvokeAsync(GetDirectoryServicesV2Args? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDirectoryServicesV2Result>("nutanix:index/getDirectoryServicesV2:getDirectoryServicesV2", args ?? new GetDirectoryServicesV2Args(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to retrieve all Directory Service(s).
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
        ///     var example = Nutanix.GetDirectoryServicesV2.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetDirectoryServicesV2Result> Invoke(GetDirectoryServicesV2InvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDirectoryServicesV2Result>("nutanix:index/getDirectoryServicesV2:getDirectoryServicesV2", args ?? new GetDirectoryServicesV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to retrieve all Directory Service(s).
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
        ///     var example = Nutanix.GetDirectoryServicesV2.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetDirectoryServicesV2Result> Invoke(GetDirectoryServicesV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetDirectoryServicesV2Result>("nutanix:index/getDirectoryServicesV2:getDirectoryServicesV2", args ?? new GetDirectoryServicesV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDirectoryServicesV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions. For example, filter '$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
        /// - createdBy
        /// - domainName
        /// - extId
        /// - name
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
        /// - createdTime
        /// - domainName
        /// - lastUpdatedTime
        /// - name
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public int? Page { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. If a $select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. it can be applied to the following fields:
        /// - createdBy
        /// - createdTime
        /// - directoryType
        /// - domainName
        /// - extId
        /// - groupSearchType
        /// - lastUpdatedTime
        /// - links
        /// - name
        /// - openLdapConfiguration/userConfiguration
        /// - openLdapConfiguration/userGroupConfiguration
        /// - secondaryUrls
        /// - serviceAccount/password
        /// - serviceAccount/username
        /// - tenantId
        /// - url
        /// - whiteListedGroups
        /// </summary>
        [Input("select")]
        public string? Select { get; set; }

        public GetDirectoryServicesV2Args()
        {
        }
        public static new GetDirectoryServicesV2Args Empty => new GetDirectoryServicesV2Args();
    }

    public sealed class GetDirectoryServicesV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions. For example, filter '$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
        /// - createdBy
        /// - domainName
        /// - extId
        /// - name
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
        /// - createdTime
        /// - domainName
        /// - lastUpdatedTime
        /// - name
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
        /// </summary>
        [Input("page")]
        public Input<int>? Page { get; set; }

        /// <summary>
        /// -(Optional) A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. If a $select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. it can be applied to the following fields:
        /// - createdBy
        /// - createdTime
        /// - directoryType
        /// - domainName
        /// - extId
        /// - groupSearchType
        /// - lastUpdatedTime
        /// - links
        /// - name
        /// - openLdapConfiguration/userConfiguration
        /// - openLdapConfiguration/userGroupConfiguration
        /// - secondaryUrls
        /// - serviceAccount/password
        /// - serviceAccount/username
        /// - tenantId
        /// - url
        /// - whiteListedGroups
        /// </summary>
        [Input("select")]
        public Input<string>? Select { get; set; }

        public GetDirectoryServicesV2InvokeArgs()
        {
        }
        public static new GetDirectoryServicesV2InvokeArgs Empty => new GetDirectoryServicesV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetDirectoryServicesV2Result
    {
        /// <summary>
        /// - list of all Directory Service(s).
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDirectoryServicesV2DirectoryServiceResult> DirectoryServices;
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
        private GetDirectoryServicesV2Result(
            ImmutableArray<Outputs.GetDirectoryServicesV2DirectoryServiceResult> directoryServices,

            string? filter,

            string id,

            int? limit,

            string? orderBy,

            int? page,

            string? select)
        {
            DirectoryServices = directoryServices;
            Filter = filter;
            Id = id;
            Limit = limit;
            OrderBy = orderBy;
            Page = page;
            Select = select;
        }
    }
}
