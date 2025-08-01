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
    /// <summary>
    /// &gt; The restore source is auto-deleted after sometime, nutanix.PcRestoreSourceV2 resource is auto-create new restore source if it was deleted, so notice that the id of the restore source resource will be different after recreation. and for update restore source, it will create a new restore source with the new configuration
    /// 
    /// Create a restore source pointing to a cluster or object store to restore the domain manager. The created restore source is intended to be deleted after use. If the restore source is not deleted using the deleteRestoreSource API, then it is auto-deleted after sometime. Also note that a restore source will not contain a backup policy. It is only used to access the backup data at the location from where the Prism Central may be restored. Credentials used to access the restore source are not validated at the time of creation of the restore source. They are validated when the restore source is used to fetch data.
    /// 
    /// ## Example Usage
    /// 
    /// ### Cluster Location
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     //defining nutanix configuration for PE
    ///     var pe = new Nutanix.Provider("pe", new()
    ///     {
    ///         Username = @var.Nutanix_pe_username,
    ///         Password = @var.Nutanix_pe_password,
    ///         Endpoint = @var.Nutanix_pe_endpoint,
    ///         Insecure = true,
    ///         Port = "9440",
    ///     });
    /// 
    ///     // restore source is auto-deleted after sometime, nutanix_pc_restore_source_v2 resource is auto-create
    ///     // new restore source if it was deleted, so notice that the id of the restore source will be different
    ///     // after recreation
    ///     var cluster_location = new Nutanix.PcRestoreSourceV2("cluster-location", new()
    ///     {
    ///         Location = new Nutanix.Inputs.PcRestoreSourceV2LocationArgs
    ///         {
    ///             ClusterLocations = new[]
    ///             {
    ///                 new Nutanix.Inputs.PcRestoreSourceV2LocationClusterLocationArgs
    ///                 {
    ///                     Configs = new[]
    ///                     {
    ///                         new Nutanix.Inputs.PcRestoreSourceV2LocationClusterLocationConfigArgs
    ///                         {
    ///                             ExtId = "323860ca-bd10-411e-9fe0-1430b62eaf45",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     }, new CustomResourceOptions
    ///     {
    ///         Provider = nutanix.Pe,
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ### Object Store Location
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     // using object store location
    ///     var object_store_location = new Nutanix.PcRestoreSourceV2("object-store-location", new()
    ///     {
    ///         Location = new Nutanix.Inputs.PcRestoreSourceV2LocationArgs
    ///         {
    ///             ObjectStoreLocations = new[]
    ///             {
    ///                 new Nutanix.Inputs.PcRestoreSourceV2LocationObjectStoreLocationArgs
    ///                 {
    ///                     ProviderConfigs = new[]
    ///                     {
    ///                         new Nutanix.Inputs.PcRestoreSourceV2LocationObjectStoreLocationProviderConfigArgs
    ///                         {
    ///                             BucketName = "nutanix-terraform-bucket",
    ///                             Region = "us-west-1",
    ///                             Credentials = new Nutanix.Inputs.PcRestoreSourceV2LocationObjectStoreLocationProviderConfigCredentialsArgs
    ///                             {
    ///                                 AccessKeyId = "IHSAJHDHADFWYTKJHFGCJKHASGJHKDSA",
    ///                                 SecretAccessKey = "JGSDHJYHGFHGHDS+JKBASDF/HSDAFHJ+SjkfbdsASDfdJFdSDFJfk",
    ///                             },
    ///                         },
    ///                     },
    ///                     BackupPolicies = new[]
    ///                     {
    ///                         new Nutanix.Inputs.PcRestoreSourceV2LocationObjectStoreLocationBackupPolicyArgs
    ///                         {
    ///                             RpoInMinutes = 120,
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/pcRestoreSourceV2:PcRestoreSourceV2")]
    public partial class PcRestoreSourceV2 : global::Pulumi.CustomResource
    {
        [Output("backupPauseReason")]
        public Output<string> BackupPauseReason { get; private set; } = null!;

        [Output("extId")]
        public Output<string> ExtId { get; private set; } = null!;

        [Output("isBackupPaused")]
        public Output<bool> IsBackupPaused { get; private set; } = null!;

        [Output("lastSyncTime")]
        public Output<string> LastSyncTime { get; private set; } = null!;

        [Output("links")]
        public Output<ImmutableArray<Outputs.PcRestoreSourceV2Link>> Links { get; private set; } = null!;

        /// <summary>
        /// -(Required) Location of the backup target. For example, a cluster or an object store endpoint, such as AWS s3.
        /// </summary>
        [Output("location")]
        public Output<Outputs.PcRestoreSourceV2Location> Location { get; private set; } = null!;

        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;


        /// <summary>
        /// Create a PcRestoreSourceV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PcRestoreSourceV2(string name, PcRestoreSourceV2Args args, CustomResourceOptions? options = null)
            : base("nutanix:index/pcRestoreSourceV2:PcRestoreSourceV2", name, args ?? new PcRestoreSourceV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private PcRestoreSourceV2(string name, Input<string> id, PcRestoreSourceV2State? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/pcRestoreSourceV2:PcRestoreSourceV2", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-nutanix",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PcRestoreSourceV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PcRestoreSourceV2 Get(string name, Input<string> id, PcRestoreSourceV2State? state = null, CustomResourceOptions? options = null)
        {
            return new PcRestoreSourceV2(name, id, state, options);
        }
    }

    public sealed class PcRestoreSourceV2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Required) Location of the backup target. For example, a cluster or an object store endpoint, such as AWS s3.
        /// </summary>
        [Input("location", required: true)]
        public Input<Inputs.PcRestoreSourceV2LocationArgs> Location { get; set; } = null!;

        public PcRestoreSourceV2Args()
        {
        }
        public static new PcRestoreSourceV2Args Empty => new PcRestoreSourceV2Args();
    }

    public sealed class PcRestoreSourceV2State : global::Pulumi.ResourceArgs
    {
        [Input("backupPauseReason")]
        public Input<string>? BackupPauseReason { get; set; }

        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        [Input("isBackupPaused")]
        public Input<bool>? IsBackupPaused { get; set; }

        [Input("lastSyncTime")]
        public Input<string>? LastSyncTime { get; set; }

        [Input("links")]
        private InputList<Inputs.PcRestoreSourceV2LinkGetArgs>? _links;
        public InputList<Inputs.PcRestoreSourceV2LinkGetArgs> Links
        {
            get => _links ?? (_links = new InputList<Inputs.PcRestoreSourceV2LinkGetArgs>());
            set => _links = value;
        }

        /// <summary>
        /// -(Required) Location of the backup target. For example, a cluster or an object store endpoint, such as AWS s3.
        /// </summary>
        [Input("location")]
        public Input<Inputs.PcRestoreSourceV2LocationGetArgs>? Location { get; set; }

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public PcRestoreSourceV2State()
        {
        }
        public static new PcRestoreSourceV2State Empty => new PcRestoreSourceV2State();
    }
}
