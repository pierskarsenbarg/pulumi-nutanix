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
    /// Run restore action in application to restore from recovery point.
    /// 
    /// ## Example Usage
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
    ///     var testSelfServiceAppRecoveryPoint = new Nutanix.SelfServiceAppRecoveryPoint("testSelfServiceAppRecoveryPoint", new()
    ///     {
    ///         AppName = "NAME OF APPLICATION",
    ///         ActionName = "SNAPSHOT ACTION NAME",
    ///         RecoveryPointName = "RECOVERY POINT NAME",
    ///     });
    /// 
    ///     var snapshots = Nutanix.GetSelfServiceAppSnapshots.Invoke(new()
    ///     {
    ///         AppName = "NAME OF APPLICATION",
    ///         Length = 250,
    ///         Offset = 0,
    ///     });
    /// 
    ///     var snapshotUuid = .Where(snapshot =&gt; snapshot.Name == "SNAPSHOT ACTION NAME").Select(snapshot =&gt; 
    ///     {
    ///         return snapshot.Uuid;
    ///     }).ToList()[0];
    /// 
    ///     // Restore from recovery point
    ///     var testSelfServiceAppRestore = new Nutanix.SelfServiceAppRestore("testSelfServiceAppRestore", new()
    ///     {
    ///         RestoreActionName = "RESTORE ACTION NAME",
    ///         AppName = "NAME OF APPLICATION",
    ///         SnapshotUuid = snapshotUuid,
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/selfServiceAppRestore:SelfServiceAppRestore")]
    public partial class SelfServiceAppRestore : global::Pulumi.CustomResource
    {
        /// <summary>
        /// - (Optional) The name of the application
        /// </summary>
        [Output("appName")]
        public Output<string?> AppName { get; private set; } = null!;

        /// <summary>
        /// - (Optional) The UUID of the application.
        /// </summary>
        [Output("appUuid")]
        public Output<string?> AppUuid { get; private set; } = null!;

        /// <summary>
        /// - (Required) The name of the restore action to be performed.
        /// </summary>
        [Output("restoreActionName")]
        public Output<string> RestoreActionName { get; private set; } = null!;

        /// <summary>
        /// - (Required) The UUID of the snapshot to which the application will be restored.
        /// 
        /// Both (`app_name` and `app_uuid`) are optional but atleast one of them should be provided for resource to work.
        /// </summary>
        [Output("snapshotUuid")]
        public Output<string> SnapshotUuid { get; private set; } = null!;

        /// <summary>
        /// - (Computed) This will be set after the restore action has been processed.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a SelfServiceAppRestore resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SelfServiceAppRestore(string name, SelfServiceAppRestoreArgs args, CustomResourceOptions? options = null)
            : base("nutanix:index/selfServiceAppRestore:SelfServiceAppRestore", name, args ?? new SelfServiceAppRestoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SelfServiceAppRestore(string name, Input<string> id, SelfServiceAppRestoreState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/selfServiceAppRestore:SelfServiceAppRestore", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SelfServiceAppRestore resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SelfServiceAppRestore Get(string name, Input<string> id, SelfServiceAppRestoreState? state = null, CustomResourceOptions? options = null)
        {
            return new SelfServiceAppRestore(name, id, state, options);
        }
    }

    public sealed class SelfServiceAppRestoreArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) The name of the application
        /// </summary>
        [Input("appName")]
        public Input<string>? AppName { get; set; }

        /// <summary>
        /// - (Optional) The UUID of the application.
        /// </summary>
        [Input("appUuid")]
        public Input<string>? AppUuid { get; set; }

        /// <summary>
        /// - (Required) The name of the restore action to be performed.
        /// </summary>
        [Input("restoreActionName", required: true)]
        public Input<string> RestoreActionName { get; set; } = null!;

        /// <summary>
        /// - (Required) The UUID of the snapshot to which the application will be restored.
        /// 
        /// Both (`app_name` and `app_uuid`) are optional but atleast one of them should be provided for resource to work.
        /// </summary>
        [Input("snapshotUuid", required: true)]
        public Input<string> SnapshotUuid { get; set; } = null!;

        public SelfServiceAppRestoreArgs()
        {
        }
        public static new SelfServiceAppRestoreArgs Empty => new SelfServiceAppRestoreArgs();
    }

    public sealed class SelfServiceAppRestoreState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) The name of the application
        /// </summary>
        [Input("appName")]
        public Input<string>? AppName { get; set; }

        /// <summary>
        /// - (Optional) The UUID of the application.
        /// </summary>
        [Input("appUuid")]
        public Input<string>? AppUuid { get; set; }

        /// <summary>
        /// - (Required) The name of the restore action to be performed.
        /// </summary>
        [Input("restoreActionName")]
        public Input<string>? RestoreActionName { get; set; }

        /// <summary>
        /// - (Required) The UUID of the snapshot to which the application will be restored.
        /// 
        /// Both (`app_name` and `app_uuid`) are optional but atleast one of them should be provided for resource to work.
        /// </summary>
        [Input("snapshotUuid")]
        public Input<string>? SnapshotUuid { get; set; }

        /// <summary>
        /// - (Computed) This will be set after the restore action has been processed.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public SelfServiceAppRestoreState()
        {
        }
        public static new SelfServiceAppRestoreState Empty => new SelfServiceAppRestoreState();
    }
}
