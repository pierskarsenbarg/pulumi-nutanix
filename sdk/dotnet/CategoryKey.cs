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
    /// Provides a Nutanix Category key resource to Create a category key name.
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
    ///         var test = new Nutanix.CategoryKey("test", new Nutanix.CategoryKeyArgs
    ///         {
    ///             Description = "App Support Category Key",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/categoryKey:CategoryKey")]
    public partial class CategoryKey : Pulumi.CustomResource
    {
        /// <summary>
        /// (Optional) The version of the API.
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("systemDefined")]
        public Output<bool> SystemDefined { get; private set; } = null!;


        /// <summary>
        /// Create a CategoryKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CategoryKey(string name, CategoryKeyArgs? args = null, CustomResourceOptions? options = null)
            : base("nutanix:index/categoryKey:CategoryKey", name, args ?? new CategoryKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CategoryKey(string name, Input<string> id, CategoryKeyState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/categoryKey:CategoryKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CategoryKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CategoryKey Get(string name, Input<string> id, CategoryKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new CategoryKey(name, id, state, options);
        }
    }

    public sealed class CategoryKeyArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public CategoryKeyArgs()
        {
        }
    }

    public sealed class CategoryKeyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Optional) The version of the API.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("systemDefined")]
        public Input<bool>? SystemDefined { get; set; }

        public CategoryKeyState()
        {
        }
    }
}