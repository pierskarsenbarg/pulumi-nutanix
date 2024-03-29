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
    public static class GetProject
    {
        /// <summary>
        /// Describe a Nutanix Project and its values (if it has them).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = PiersKarsenbarg.Nutanix;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var subnet = new Nutanix.Subnet("subnet", new()
        ///     {
        ///         ClusterUuid = "&lt;YOUR_CLUSTER_ID&gt;",
        ///         Description = "Description of my unit test VLAN",
        ///         VlanId = 31,
        ///         SubnetType = "VLAN",
        ///         SubnetIp = "10.250.140.0",
        ///         DefaultGatewayIp = "10.250.140.1",
        ///         PrefixLength = 24,
        ///         DhcpOptions = 
        ///         {
        ///             { "boot_file_name", "bootfile" },
        ///             { "domain_name", "nutanix" },
        ///             { "tftp_server_name", "10.250.140.200" },
        ///         },
        ///         DhcpDomainNameServerLists = new[]
        ///         {
        ///             "8.8.8.8",
        ///             "4.2.2.2",
        ///         },
        ///         DhcpDomainSearchLists = new[]
        ///         {
        ///             "terraform.nutanix.com",
        ///             "terraform.unit.test.com",
        ///         },
        ///     });
        /// 
        ///     var projectTest = new Nutanix.Project("projectTest", new()
        ///     {
        ///         Description = "This is my project",
        ///         Categories = new[]
        ///         {
        ///             new Nutanix.Inputs.ProjectCategoryArgs
        ///             {
        ///                 Name = "Environment",
        ///                 Value = "Staging",
        ///             },
        ///         },
        ///         ResourceDomain = new Nutanix.Inputs.ProjectResourceDomainArgs
        ///         {
        ///             Resources = new[]
        ///             {
        ///                 new Nutanix.Inputs.ProjectResourceDomainResourceArgs
        ///                 {
        ///                     Limit = 4,
        ///                     ResourceType = "STORAGE",
        ///                 },
        ///             },
        ///         },
        ///         DefaultSubnetReference = new Nutanix.Inputs.ProjectDefaultSubnetReferenceArgs
        ///         {
        ///             Uuid = subnet.Metadata.Apply(metadata =&gt; metadata.Uuid),
        ///         },
        ///         ApiVersion = "3.1",
        ///     });
        /// 
        ///     var test = Nutanix.GetProject.Invoke(new()
        ///     {
        ///         ProjectId = projectTest.Id,
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProjectResult> InvokeAsync(GetProjectArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProjectResult>("nutanix:index/getProject:getProject", args ?? new GetProjectArgs(), options.WithDefaults());

        /// <summary>
        /// Describe a Nutanix Project and its values (if it has them).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = PiersKarsenbarg.Nutanix;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var subnet = new Nutanix.Subnet("subnet", new()
        ///     {
        ///         ClusterUuid = "&lt;YOUR_CLUSTER_ID&gt;",
        ///         Description = "Description of my unit test VLAN",
        ///         VlanId = 31,
        ///         SubnetType = "VLAN",
        ///         SubnetIp = "10.250.140.0",
        ///         DefaultGatewayIp = "10.250.140.1",
        ///         PrefixLength = 24,
        ///         DhcpOptions = 
        ///         {
        ///             { "boot_file_name", "bootfile" },
        ///             { "domain_name", "nutanix" },
        ///             { "tftp_server_name", "10.250.140.200" },
        ///         },
        ///         DhcpDomainNameServerLists = new[]
        ///         {
        ///             "8.8.8.8",
        ///             "4.2.2.2",
        ///         },
        ///         DhcpDomainSearchLists = new[]
        ///         {
        ///             "terraform.nutanix.com",
        ///             "terraform.unit.test.com",
        ///         },
        ///     });
        /// 
        ///     var projectTest = new Nutanix.Project("projectTest", new()
        ///     {
        ///         Description = "This is my project",
        ///         Categories = new[]
        ///         {
        ///             new Nutanix.Inputs.ProjectCategoryArgs
        ///             {
        ///                 Name = "Environment",
        ///                 Value = "Staging",
        ///             },
        ///         },
        ///         ResourceDomain = new Nutanix.Inputs.ProjectResourceDomainArgs
        ///         {
        ///             Resources = new[]
        ///             {
        ///                 new Nutanix.Inputs.ProjectResourceDomainResourceArgs
        ///                 {
        ///                     Limit = 4,
        ///                     ResourceType = "STORAGE",
        ///                 },
        ///             },
        ///         },
        ///         DefaultSubnetReference = new Nutanix.Inputs.ProjectDefaultSubnetReferenceArgs
        ///         {
        ///             Uuid = subnet.Metadata.Apply(metadata =&gt; metadata.Uuid),
        ///         },
        ///         ApiVersion = "3.1",
        ///     });
        /// 
        ///     var test = Nutanix.GetProject.Invoke(new()
        ///     {
        ///         ProjectId = projectTest.Id,
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetProjectResult> Invoke(GetProjectInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProjectResult>("nutanix:index/getProject:getProject", args ?? new GetProjectInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProjectArgs : global::Pulumi.InvokeArgs
    {
        [Input("categories")]
        private List<Inputs.GetProjectCategoryArgs>? _categories;
        public List<Inputs.GetProjectCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new List<Inputs.GetProjectCategoryArgs>());
            set => _categories = value;
        }

        [Input("externalUserGroupReferenceLists")]
        private List<Inputs.GetProjectExternalUserGroupReferenceListArgs>? _externalUserGroupReferenceLists;

        /// <summary>
        /// List of directory service user groups. These groups are not managed by Nutanix.
        /// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `user_group`
        /// * `external_user_group_reference_list.#.uuid` - The UUID of a user_group
        /// * `external_user_group_reference_list.#.name` - The name of a user_group
        /// </summary>
        public List<Inputs.GetProjectExternalUserGroupReferenceListArgs> ExternalUserGroupReferenceLists
        {
            get => _externalUserGroupReferenceLists ?? (_externalUserGroupReferenceLists = new List<Inputs.GetProjectExternalUserGroupReferenceListArgs>());
            set => _externalUserGroupReferenceLists = value;
        }

        /// <summary>
        /// - (Required) The `id` of the project.
        /// </summary>
        [Input("projectId")]
        public string? ProjectId { get; set; }

        [Input("projectName")]
        public string? ProjectName { get; set; }

        [Input("subnetReferenceLists")]
        private List<Inputs.GetProjectSubnetReferenceListArgs>? _subnetReferenceLists;

        /// <summary>
        /// List of subnets for the project.
        /// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
        /// * `subnet_reference_list.#.uuid` - The UUID of a subnet
        /// * `subnet_reference_list.#.name` - The name of a subnet.
        /// </summary>
        public List<Inputs.GetProjectSubnetReferenceListArgs> SubnetReferenceLists
        {
            get => _subnetReferenceLists ?? (_subnetReferenceLists = new List<Inputs.GetProjectSubnetReferenceListArgs>());
            set => _subnetReferenceLists = value;
        }

        [Input("userReferenceLists")]
        private List<Inputs.GetProjectUserReferenceListArgs>? _userReferenceLists;

        /// <summary>
        /// List of users in the project.
        /// * `user_reference_list.#.kind` - The kind name. Default value is `user`
        /// * `user_reference_list.#.uuid` - The UUID of a user
        /// * `user_reference_list.#.name` - The name of a user.
        /// </summary>
        public List<Inputs.GetProjectUserReferenceListArgs> UserReferenceLists
        {
            get => _userReferenceLists ?? (_userReferenceLists = new List<Inputs.GetProjectUserReferenceListArgs>());
            set => _userReferenceLists = value;
        }

        public GetProjectArgs()
        {
        }
        public static new GetProjectArgs Empty => new GetProjectArgs();
    }

    public sealed class GetProjectInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("categories")]
        private InputList<Inputs.GetProjectCategoryInputArgs>? _categories;
        public InputList<Inputs.GetProjectCategoryInputArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.GetProjectCategoryInputArgs>());
            set => _categories = value;
        }

        [Input("externalUserGroupReferenceLists")]
        private InputList<Inputs.GetProjectExternalUserGroupReferenceListInputArgs>? _externalUserGroupReferenceLists;

        /// <summary>
        /// List of directory service user groups. These groups are not managed by Nutanix.
        /// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `user_group`
        /// * `external_user_group_reference_list.#.uuid` - The UUID of a user_group
        /// * `external_user_group_reference_list.#.name` - The name of a user_group
        /// </summary>
        public InputList<Inputs.GetProjectExternalUserGroupReferenceListInputArgs> ExternalUserGroupReferenceLists
        {
            get => _externalUserGroupReferenceLists ?? (_externalUserGroupReferenceLists = new InputList<Inputs.GetProjectExternalUserGroupReferenceListInputArgs>());
            set => _externalUserGroupReferenceLists = value;
        }

        /// <summary>
        /// - (Required) The `id` of the project.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("projectName")]
        public Input<string>? ProjectName { get; set; }

        [Input("subnetReferenceLists")]
        private InputList<Inputs.GetProjectSubnetReferenceListInputArgs>? _subnetReferenceLists;

        /// <summary>
        /// List of subnets for the project.
        /// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
        /// * `subnet_reference_list.#.uuid` - The UUID of a subnet
        /// * `subnet_reference_list.#.name` - The name of a subnet.
        /// </summary>
        public InputList<Inputs.GetProjectSubnetReferenceListInputArgs> SubnetReferenceLists
        {
            get => _subnetReferenceLists ?? (_subnetReferenceLists = new InputList<Inputs.GetProjectSubnetReferenceListInputArgs>());
            set => _subnetReferenceLists = value;
        }

        [Input("userReferenceLists")]
        private InputList<Inputs.GetProjectUserReferenceListInputArgs>? _userReferenceLists;

        /// <summary>
        /// List of users in the project.
        /// * `user_reference_list.#.kind` - The kind name. Default value is `user`
        /// * `user_reference_list.#.uuid` - The UUID of a user
        /// * `user_reference_list.#.name` - The name of a user.
        /// </summary>
        public InputList<Inputs.GetProjectUserReferenceListInputArgs> UserReferenceLists
        {
            get => _userReferenceLists ?? (_userReferenceLists = new InputList<Inputs.GetProjectUserReferenceListInputArgs>());
            set => _userReferenceLists = value;
        }

        public GetProjectInvokeArgs()
        {
        }
        public static new GetProjectInvokeArgs Empty => new GetProjectInvokeArgs();
    }


    [OutputType]
    public sealed class GetProjectResult
    {
        /// <summary>
        /// List of accounts associated with the project.
        /// * `account_reference_list.#.kind` - The kind name. Default value is `account`
        /// * `account_reference_list.#.uuid` - The UUID of an account.
        /// * `account_reference_list.#.name` - The name of an account.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectAccountReferenceListResult> AccountReferenceLists;
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetProjectCategoryResult> Categories;
        /// <summary>
        /// Reference to a subnet.
        /// * `default_subnet_reference.kind` - The kind name. Default value is `subnet`
        /// * `default_subnet_reference.uuid` - The UUID of a subnet.
        /// * `default_subnet_reference.name` - The name of a subnet.
        /// </summary>
        public readonly ImmutableDictionary<string, string> DefaultSubnetReference;
        /// <summary>
        /// A description for project.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// List of environments associated with the project.
        /// * `environment_reference_list.#.kind` - The kind name. Default value is `environment`
        /// * `environment_reference_list.#.uuid` - The UUID of an environment.
        /// * `environment_reference_list.#.name` - The name of an environment.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectEnvironmentReferenceListResult> EnvironmentReferenceLists;
        /// <summary>
        /// List of external networks associated with the project.
        /// * `external_network_list.#.uuid` - The UUID of a network.
        /// * `external_network_list.#.name` - The name of a network.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectExternalNetworkListResult> ExternalNetworkLists;
        /// <summary>
        /// List of directory service user groups. These groups are not managed by Nutanix.
        /// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `user_group`
        /// * `external_user_group_reference_list.#.uuid` - The UUID of a user_group
        /// * `external_user_group_reference_list.#.name` - The name of a user_group
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectExternalUserGroupReferenceListResult> ExternalUserGroupReferenceLists;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool IsDefault;
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// the name.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableDictionary<string, string> OwnerReference;
        public readonly string? ProjectId;
        public readonly string? ProjectName;
        public readonly ImmutableDictionary<string, string> ProjectReference;
        /// <summary>
        /// The status for a resource domain (limits and values)
        /// * `resource_domain.resources` Array of the utilization/limit for resource types
        /// * `resource_domain.resources.#.limit` The resource consumption limit (unspecified is unlimited)
        /// * `resource_domain.resources.#.resource_type` The type of resource (for example storage, CPUs)
        /// * `resource_domain.resources.#.units` - The units of the resource type
        /// * `resource_domain.resources.#.value` - The amount of resource consumed
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectResourceDomainResult> ResourceDomains;
        public readonly string State;
        /// <summary>
        /// List of subnets for the project.
        /// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
        /// * `subnet_reference_list.#.uuid` - The UUID of a subnet
        /// * `subnet_reference_list.#.name` - The name of a subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectSubnetReferenceListResult> SubnetReferenceLists;
        /// <summary>
        /// List of users in the project.
        /// * `user_reference_list.#.kind` - The kind name. Default value is `user`
        /// * `user_reference_list.#.uuid` - The UUID of a user
        /// * `user_reference_list.#.name` - The name of a user.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectUserReferenceListResult> UserReferenceLists;

        [OutputConstructor]
        private GetProjectResult(
            ImmutableArray<Outputs.GetProjectAccountReferenceListResult> accountReferenceLists,

            string apiVersion,

            ImmutableArray<Outputs.GetProjectCategoryResult> categories,

            ImmutableDictionary<string, string> defaultSubnetReference,

            string description,

            ImmutableArray<Outputs.GetProjectEnvironmentReferenceListResult> environmentReferenceLists,

            ImmutableArray<Outputs.GetProjectExternalNetworkListResult> externalNetworkLists,

            ImmutableArray<Outputs.GetProjectExternalUserGroupReferenceListResult> externalUserGroupReferenceLists,

            string id,

            bool isDefault,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, string> ownerReference,

            string? projectId,

            string? projectName,

            ImmutableDictionary<string, string> projectReference,

            ImmutableArray<Outputs.GetProjectResourceDomainResult> resourceDomains,

            string state,

            ImmutableArray<Outputs.GetProjectSubnetReferenceListResult> subnetReferenceLists,

            ImmutableArray<Outputs.GetProjectUserReferenceListResult> userReferenceLists)
        {
            AccountReferenceLists = accountReferenceLists;
            ApiVersion = apiVersion;
            Categories = categories;
            DefaultSubnetReference = defaultSubnetReference;
            Description = description;
            EnvironmentReferenceLists = environmentReferenceLists;
            ExternalNetworkLists = externalNetworkLists;
            ExternalUserGroupReferenceLists = externalUserGroupReferenceLists;
            Id = id;
            IsDefault = isDefault;
            Metadata = metadata;
            Name = name;
            OwnerReference = ownerReference;
            ProjectId = projectId;
            ProjectName = projectName;
            ProjectReference = projectReference;
            ResourceDomains = resourceDomains;
            State = state;
            SubnetReferenceLists = subnetReferenceLists;
            UserReferenceLists = userReferenceLists;
        }
    }
}
