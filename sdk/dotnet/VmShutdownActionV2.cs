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
    /// Collaborative reboot or shutdown of a Virtual Machine through the ACPI support in the operating system. Also, Collaborative reboot or shutdown of a Virtual Machine, requesting Nutanix Guest Tools to trigger a reboot or shutdown from within the VM.
    /// </summary>
    [NutanixResourceType("nutanix:index/vmShutdownActionV2:VmShutdownActionV2")]
    public partial class VmShutdownActionV2 : global::Pulumi.CustomResource
    {
        /// <summary>
        /// It supports "shutdown", "guest_shutdown", "reboot", "guest_reboot".
        /// </summary>
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        /// <summary>
        /// The globally unique identifier of a VM. It should be of type UUID.
        /// </summary>
        [Output("extId")]
        public Output<string> ExtId { get; private set; } = null!;

        /// <summary>
        /// Additional configuration for Nutanix Gust Tools power state transition. It should be only used with `guest_shutdown` or `guest_reboot`.
        /// </summary>
        [Output("guestPowerStateTransitionConfigs")]
        public Output<ImmutableArray<Outputs.VmShutdownActionV2GuestPowerStateTransitionConfig>> GuestPowerStateTransitionConfigs { get; private set; } = null!;


        /// <summary>
        /// Create a VmShutdownActionV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VmShutdownActionV2(string name, VmShutdownActionV2Args args, CustomResourceOptions? options = null)
            : base("nutanix:index/vmShutdownActionV2:VmShutdownActionV2", name, args ?? new VmShutdownActionV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private VmShutdownActionV2(string name, Input<string> id, VmShutdownActionV2State? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/vmShutdownActionV2:VmShutdownActionV2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VmShutdownActionV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VmShutdownActionV2 Get(string name, Input<string> id, VmShutdownActionV2State? state = null, CustomResourceOptions? options = null)
        {
            return new VmShutdownActionV2(name, id, state, options);
        }
    }

    public sealed class VmShutdownActionV2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// It supports "shutdown", "guest_shutdown", "reboot", "guest_reboot".
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// The globally unique identifier of a VM. It should be of type UUID.
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        [Input("guestPowerStateTransitionConfigs")]
        private InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigArgs>? _guestPowerStateTransitionConfigs;

        /// <summary>
        /// Additional configuration for Nutanix Gust Tools power state transition. It should be only used with `guest_shutdown` or `guest_reboot`.
        /// </summary>
        public InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigArgs> GuestPowerStateTransitionConfigs
        {
            get => _guestPowerStateTransitionConfigs ?? (_guestPowerStateTransitionConfigs = new InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigArgs>());
            set => _guestPowerStateTransitionConfigs = value;
        }

        public VmShutdownActionV2Args()
        {
        }
        public static new VmShutdownActionV2Args Empty => new VmShutdownActionV2Args();
    }

    public sealed class VmShutdownActionV2State : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// It supports "shutdown", "guest_shutdown", "reboot", "guest_reboot".
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// The globally unique identifier of a VM. It should be of type UUID.
        /// </summary>
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        [Input("guestPowerStateTransitionConfigs")]
        private InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigGetArgs>? _guestPowerStateTransitionConfigs;

        /// <summary>
        /// Additional configuration for Nutanix Gust Tools power state transition. It should be only used with `guest_shutdown` or `guest_reboot`.
        /// </summary>
        public InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigGetArgs> GuestPowerStateTransitionConfigs
        {
            get => _guestPowerStateTransitionConfigs ?? (_guestPowerStateTransitionConfigs = new InputList<Inputs.VmShutdownActionV2GuestPowerStateTransitionConfigGetArgs>());
            set => _guestPowerStateTransitionConfigs = value;
        }

        public VmShutdownActionV2State()
        {
        }
        public static new VmShutdownActionV2State Empty => new VmShutdownActionV2State();
    }
}
