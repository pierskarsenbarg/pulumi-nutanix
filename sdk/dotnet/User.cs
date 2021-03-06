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
    /// <summary>
    /// Provides a resource to create a user based on the input parameters.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var user = new Nutanix.User("user", new Nutanix.UserArgs
    ///         {
    ///             DirectoryServiceUser = new Nutanix.Inputs.UserDirectoryServiceUserArgs
    ///             {
    ///                 DirectoryServiceReference = new Nutanix.Inputs.UserDirectoryServiceUserDirectoryServiceReferenceArgs
    ///                 {
    ///                     Uuid = "&lt;directory-service-uuid&gt;",
    ///                 },
    ///                 UserPrincipalName = "test-user@ntnxlab.local",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var user = new Nutanix.User("user", new Nutanix.UserArgs
    ///         {
    ///             IdentityProviderUser = new Nutanix.Inputs.UserIdentityProviderUserArgs
    ///             {
    ///                 IdentityProviderReference = new Nutanix.Inputs.UserIdentityProviderUserIdentityProviderReferenceArgs
    ///                 {
    ///                     Uuid = "&lt;identity-provider-uuid&gt;",
    ///                 },
    ///                 Username = "username",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/user:User")]
    public partial class User : Pulumi.CustomResource
    {
        [Output("accessControlPolicyReferenceLists")]
        public Output<ImmutableArray<Outputs.UserAccessControlPolicyReferenceList>> AccessControlPolicyReferenceLists { get; private set; } = null!;

        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the entity.
        /// * `name`: - The name of the user.
        /// * `user_type`: - The name of the user.
        /// * `display_name`: - The display name of the user (common name) provided by the directory service.
        /// * `project_reference_list`: - A list of projects the user is part of. See #reference for more details.
        /// * `access_control_policy_reference_list`: - List of ACP references. See #reference for more details.
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("categories")]
        public Output<ImmutableArray<Outputs.UserCategory>> Categories { get; private set; } = null!;

        [Output("directoryServiceUser")]
        public Output<Outputs.UserDirectoryServiceUser> DirectoryServiceUser { get; private set; } = null!;

        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        [Output("identityProviderUser")]
        public Output<Outputs.UserIdentityProviderUser> IdentityProviderUser { get; private set; } = null!;

        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>> Metadata { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("ownerReference")]
        public Output<ImmutableDictionary<string, string>> OwnerReference { get; private set; } = null!;

        [Output("projectReference")]
        public Output<ImmutableDictionary<string, string>?> ProjectReference { get; private set; } = null!;

        [Output("projectReferenceLists")]
        public Output<ImmutableArray<Outputs.UserProjectReferenceList>> ProjectReferenceLists { get; private set; } = null!;

        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        [Output("userType")]
        public Output<string> UserType { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs? args = null, CustomResourceOptions? options = null)
            : base("nutanix:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/user:User", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pierskarsenbarg/pulumi-nutanix/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        [Input("categories")]
        private InputList<Inputs.UserCategoryArgs>? _categories;
        public InputList<Inputs.UserCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.UserCategoryArgs>());
            set => _categories = value;
        }

        [Input("directoryServiceUser")]
        public Input<Inputs.UserDirectoryServiceUserArgs>? DirectoryServiceUser { get; set; }

        [Input("identityProviderUser")]
        public Input<Inputs.UserIdentityProviderUserArgs>? IdentityProviderUser { get; set; }

        [Input("ownerReference")]
        private InputMap<string>? _ownerReference;
        public InputMap<string> OwnerReference
        {
            get => _ownerReference ?? (_ownerReference = new InputMap<string>());
            set => _ownerReference = value;
        }

        [Input("projectReference")]
        private InputMap<string>? _projectReference;
        public InputMap<string> ProjectReference
        {
            get => _projectReference ?? (_projectReference = new InputMap<string>());
            set => _projectReference = value;
        }

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        [Input("accessControlPolicyReferenceLists")]
        private InputList<Inputs.UserAccessControlPolicyReferenceListGetArgs>? _accessControlPolicyReferenceLists;
        public InputList<Inputs.UserAccessControlPolicyReferenceListGetArgs> AccessControlPolicyReferenceLists
        {
            get => _accessControlPolicyReferenceLists ?? (_accessControlPolicyReferenceLists = new InputList<Inputs.UserAccessControlPolicyReferenceListGetArgs>());
            set => _accessControlPolicyReferenceLists = value;
        }

        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the entity.
        /// * `name`: - The name of the user.
        /// * `user_type`: - The name of the user.
        /// * `display_name`: - The display name of the user (common name) provided by the directory service.
        /// * `project_reference_list`: - A list of projects the user is part of. See #reference for more details.
        /// * `access_control_policy_reference_list`: - List of ACP references. See #reference for more details.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("categories")]
        private InputList<Inputs.UserCategoryGetArgs>? _categories;
        public InputList<Inputs.UserCategoryGetArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.UserCategoryGetArgs>());
            set => _categories = value;
        }

        [Input("directoryServiceUser")]
        public Input<Inputs.UserDirectoryServiceUserGetArgs>? DirectoryServiceUser { get; set; }

        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("identityProviderUser")]
        public Input<Inputs.UserIdentityProviderUserGetArgs>? IdentityProviderUser { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerReference")]
        private InputMap<string>? _ownerReference;
        public InputMap<string> OwnerReference
        {
            get => _ownerReference ?? (_ownerReference = new InputMap<string>());
            set => _ownerReference = value;
        }

        [Input("projectReference")]
        private InputMap<string>? _projectReference;
        public InputMap<string> ProjectReference
        {
            get => _projectReference ?? (_projectReference = new InputMap<string>());
            set => _projectReference = value;
        }

        [Input("projectReferenceLists")]
        private InputList<Inputs.UserProjectReferenceListGetArgs>? _projectReferenceLists;
        public InputList<Inputs.UserProjectReferenceListGetArgs> ProjectReferenceLists
        {
            get => _projectReferenceLists ?? (_projectReferenceLists = new InputList<Inputs.UserProjectReferenceListGetArgs>());
            set => _projectReferenceLists = value;
        }

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("userType")]
        public Input<string>? UserType { get; set; }

        public UserState()
        {
        }
    }
}
