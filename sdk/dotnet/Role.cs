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
    /// Provides a resource to create a role based on the input parameters.
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
    ///         var test = new Nutanix.Role("test", new Nutanix.RoleArgs
    ///         {
    ///             Description = "DESCRIPTION",
    ///             PermissionReferenceLists = 
    ///             {
    ///                 new Nutanix.Inputs.RolePermissionReferenceListArgs
    ///                 {
    ///                     Kind = "permission",
    ///                     Uuid = "ID OF PERMISSION",
    ///                 },
    ///                 new Nutanix.Inputs.RolePermissionReferenceListArgs
    ///                 {
    ///                     Kind = "permission",
    ///                     Uuid = "ID OF PERMISSION",
    ///                 },
    ///                 new Nutanix.Inputs.RolePermissionReferenceListArgs
    ///                 {
    ///                     Kind = "permission",
    ///                     Uuid = "ID OF PERMISSION",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/role:Role")]
    public partial class Role : Pulumi.CustomResource
    {
        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the role.
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("categories")]
        public Output<ImmutableArray<Outputs.RoleCategory>> Categories { get; private set; } = null!;

        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>> Metadata { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("ownerReference")]
        public Output<Outputs.RoleOwnerReference> OwnerReference { get; private set; } = null!;

        [Output("permissionReferenceLists")]
        public Output<ImmutableArray<Outputs.RolePermissionReferenceList>> PermissionReferenceLists { get; private set; } = null!;

        [Output("projectReference")]
        public Output<Outputs.RoleProjectReference> ProjectReference { get; private set; } = null!;

        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a Role resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Role(string name, RoleArgs args, CustomResourceOptions? options = null)
            : base("nutanix:index/role:Role", name, args ?? new RoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Role(string name, Input<string> id, RoleState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/role:Role", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pierskarsenbarg/pulumi-nutanix/releases/download/v${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Role resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Role Get(string name, Input<string> id, RoleState? state = null, CustomResourceOptions? options = null)
        {
            return new Role(name, id, state, options);
        }
    }

    public sealed class RoleArgs : Pulumi.ResourceArgs
    {
        [Input("categories")]
        private InputList<Inputs.RoleCategoryArgs>? _categories;
        public InputList<Inputs.RoleCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.RoleCategoryArgs>());
            set => _categories = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerReference")]
        public Input<Inputs.RoleOwnerReferenceArgs>? OwnerReference { get; set; }

        [Input("permissionReferenceLists", required: true)]
        private InputList<Inputs.RolePermissionReferenceListArgs>? _permissionReferenceLists;
        public InputList<Inputs.RolePermissionReferenceListArgs> PermissionReferenceLists
        {
            get => _permissionReferenceLists ?? (_permissionReferenceLists = new InputList<Inputs.RolePermissionReferenceListArgs>());
            set => _permissionReferenceLists = value;
        }

        [Input("projectReference")]
        public Input<Inputs.RoleProjectReferenceArgs>? ProjectReference { get; set; }

        public RoleArgs()
        {
        }
    }

    public sealed class RoleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the role.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("categories")]
        private InputList<Inputs.RoleCategoryGetArgs>? _categories;
        public InputList<Inputs.RoleCategoryGetArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.RoleCategoryGetArgs>());
            set => _categories = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

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
        public Input<Inputs.RoleOwnerReferenceGetArgs>? OwnerReference { get; set; }

        [Input("permissionReferenceLists")]
        private InputList<Inputs.RolePermissionReferenceListGetArgs>? _permissionReferenceLists;
        public InputList<Inputs.RolePermissionReferenceListGetArgs> PermissionReferenceLists
        {
            get => _permissionReferenceLists ?? (_permissionReferenceLists = new InputList<Inputs.RolePermissionReferenceListGetArgs>());
            set => _permissionReferenceLists = value;
        }

        [Input("projectReference")]
        public Input<Inputs.RoleProjectReferenceGetArgs>? ProjectReference { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        public RoleState()
        {
        }
    }
}