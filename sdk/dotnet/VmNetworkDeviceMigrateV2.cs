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
    [NutanixResourceType("nutanix:index/vmNetworkDeviceMigrateV2:VmNetworkDeviceMigrateV2")]
    public partial class VmNetworkDeviceMigrateV2 : global::Pulumi.CustomResource
    {
        [Output("extId")]
        public Output<string> ExtId { get; private set; } = null!;

        [Output("ipAddresses")]
        public Output<ImmutableArray<Outputs.VmNetworkDeviceMigrateV2IpAddress>> IpAddresses { get; private set; } = null!;

        [Output("migrateType")]
        public Output<string> MigrateType { get; private set; } = null!;

        [Output("subnets")]
        public Output<ImmutableArray<Outputs.VmNetworkDeviceMigrateV2Subnet>> Subnets { get; private set; } = null!;

        [Output("vmExtId")]
        public Output<string> VmExtId { get; private set; } = null!;


        /// <summary>
        /// Create a VmNetworkDeviceMigrateV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VmNetworkDeviceMigrateV2(string name, VmNetworkDeviceMigrateV2Args args, CustomResourceOptions? options = null)
            : base("nutanix:index/vmNetworkDeviceMigrateV2:VmNetworkDeviceMigrateV2", name, args ?? new VmNetworkDeviceMigrateV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private VmNetworkDeviceMigrateV2(string name, Input<string> id, VmNetworkDeviceMigrateV2State? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/vmNetworkDeviceMigrateV2:VmNetworkDeviceMigrateV2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VmNetworkDeviceMigrateV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VmNetworkDeviceMigrateV2 Get(string name, Input<string> id, VmNetworkDeviceMigrateV2State? state = null, CustomResourceOptions? options = null)
        {
            return new VmNetworkDeviceMigrateV2(name, id, state, options);
        }
    }

    public sealed class VmNetworkDeviceMigrateV2Args : global::Pulumi.ResourceArgs
    {
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        [Input("ipAddresses")]
        private InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressArgs>? _ipAddresses;
        public InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressArgs>());
            set => _ipAddresses = value;
        }

        [Input("migrateType", required: true)]
        public Input<string> MigrateType { get; set; } = null!;

        [Input("subnets", required: true)]
        private InputList<Inputs.VmNetworkDeviceMigrateV2SubnetArgs>? _subnets;
        public InputList<Inputs.VmNetworkDeviceMigrateV2SubnetArgs> Subnets
        {
            get => _subnets ?? (_subnets = new InputList<Inputs.VmNetworkDeviceMigrateV2SubnetArgs>());
            set => _subnets = value;
        }

        [Input("vmExtId", required: true)]
        public Input<string> VmExtId { get; set; } = null!;

        public VmNetworkDeviceMigrateV2Args()
        {
        }
        public static new VmNetworkDeviceMigrateV2Args Empty => new VmNetworkDeviceMigrateV2Args();
    }

    public sealed class VmNetworkDeviceMigrateV2State : global::Pulumi.ResourceArgs
    {
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        [Input("ipAddresses")]
        private InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressGetArgs>? _ipAddresses;
        public InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressGetArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.VmNetworkDeviceMigrateV2IpAddressGetArgs>());
            set => _ipAddresses = value;
        }

        [Input("migrateType")]
        public Input<string>? MigrateType { get; set; }

        [Input("subnets")]
        private InputList<Inputs.VmNetworkDeviceMigrateV2SubnetGetArgs>? _subnets;
        public InputList<Inputs.VmNetworkDeviceMigrateV2SubnetGetArgs> Subnets
        {
            get => _subnets ?? (_subnets = new InputList<Inputs.VmNetworkDeviceMigrateV2SubnetGetArgs>());
            set => _subnets = value;
        }

        [Input("vmExtId")]
        public Input<string>? VmExtId { get; set; }

        public VmNetworkDeviceMigrateV2State()
        {
        }
        public static new VmNetworkDeviceMigrateV2State Empty => new VmNetworkDeviceMigrateV2State();
    }
}
