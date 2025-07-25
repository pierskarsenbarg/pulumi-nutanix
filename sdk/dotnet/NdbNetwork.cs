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
    /// Provides a resource to create VLANs and IP address pools that are managed both in NDB and outside NDB.
    /// 
    /// ## Example Usage
    /// 
    /// ### resource to create network for NDB
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var name = new Nutanix.NdbNetwork("name", new()
    ///     {
    ///         ClusterId = "{{ cluster_id }}",
    ///         Gateway = "{{ gatway for the vlan }}",
    ///         IpPools = new[]
    ///         {
    ///             new Nutanix.Inputs.NdbNetworkIpPoolArgs
    ///             {
    ///                 EndIp = "{{ ending address range }}",
    ///                 StartIp = "{{ starting address range}}",
    ///             },
    ///         },
    ///         PrimaryDns = " {{ primary dns for the vlan }}",
    ///         SecondaryDns = "{{secondary dns for the vlan }}",
    ///         SubnetMask = "{{ subnet mask for the vlan}}",
    ///         Type = "Static",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/ndbNetwork:NdbNetwork")]
    public partial class NdbNetwork : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Select the Nutanix cluster on which you want to add the VLAN.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// dns domain for vlan. (Static IP address assignment only)
        /// </summary>
        [Output("dnsDomain")]
        public Output<string?> DnsDomain { get; private set; } = null!;

        /// <summary>
        /// Gateway for vlan. Supports in Static IP address assignment only
        /// </summary>
        [Output("gateway")]
        public Output<string?> Gateway { get; private set; } = null!;

        /// <summary>
        /// Manage IP Address Pool in NDB option if you want to assign static IP addresses to your database server VMs
        /// </summary>
        [Output("ipPools")]
        public Output<ImmutableArray<Outputs.NdbNetworkIpPool>> IpPools { get; private set; } = null!;

        /// <summary>
        /// Managed by NDB or not
        /// </summary>
        [Output("managed")]
        public Output<bool> Managed { get; private set; } = null!;

        /// <summary>
        /// Name of the vlan to be attached in NDB
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// primary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Output("primaryDns")]
        public Output<string?> PrimaryDns { get; private set; } = null!;

        /// <summary>
        /// properties of network
        /// </summary>
        [Output("properties")]
        public Output<ImmutableArray<Outputs.NdbNetworkProperty>> Properties { get; private set; } = null!;

        /// <summary>
        /// properties map of network
        /// </summary>
        [Output("propertiesMaps")]
        public Output<ImmutableArray<Outputs.NdbNetworkPropertiesMap>> PropertiesMaps { get; private set; } = null!;

        /// <summary>
        /// secondary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Output("secondaryDns")]
        public Output<string?> SecondaryDns { get; private set; } = null!;

        /// <summary>
        /// stretched vlan id
        /// </summary>
        [Output("stretchedVlanId")]
        public Output<string> StretchedVlanId { get; private set; } = null!;

        /// <summary>
        /// Subnet mask for vlan. (Static IP address assignment only)
        /// </summary>
        [Output("subnetMask")]
        public Output<string?> SubnetMask { get; private set; } = null!;

        /// <summary>
        /// Vlan type. Supports [DHCP, Static]
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a NdbNetwork resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NdbNetwork(string name, NdbNetworkArgs args, CustomResourceOptions? options = null)
            : base("nutanix:index/ndbNetwork:NdbNetwork", name, args ?? new NdbNetworkArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NdbNetwork(string name, Input<string> id, NdbNetworkState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/ndbNetwork:NdbNetwork", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NdbNetwork resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NdbNetwork Get(string name, Input<string> id, NdbNetworkState? state = null, CustomResourceOptions? options = null)
        {
            return new NdbNetwork(name, id, state, options);
        }
    }

    public sealed class NdbNetworkArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select the Nutanix cluster on which you want to add the VLAN.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// dns domain for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("dnsDomain")]
        public Input<string>? DnsDomain { get; set; }

        /// <summary>
        /// Gateway for vlan. Supports in Static IP address assignment only
        /// </summary>
        [Input("gateway")]
        public Input<string>? Gateway { get; set; }

        [Input("ipPools")]
        private InputList<Inputs.NdbNetworkIpPoolArgs>? _ipPools;

        /// <summary>
        /// Manage IP Address Pool in NDB option if you want to assign static IP addresses to your database server VMs
        /// </summary>
        public InputList<Inputs.NdbNetworkIpPoolArgs> IpPools
        {
            get => _ipPools ?? (_ipPools = new InputList<Inputs.NdbNetworkIpPoolArgs>());
            set => _ipPools = value;
        }

        /// <summary>
        /// Name of the vlan to be attached in NDB
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// primary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("primaryDns")]
        public Input<string>? PrimaryDns { get; set; }

        /// <summary>
        /// secondary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("secondaryDns")]
        public Input<string>? SecondaryDns { get; set; }

        /// <summary>
        /// Subnet mask for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("subnetMask")]
        public Input<string>? SubnetMask { get; set; }

        /// <summary>
        /// Vlan type. Supports [DHCP, Static]
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public NdbNetworkArgs()
        {
        }
        public static new NdbNetworkArgs Empty => new NdbNetworkArgs();
    }

    public sealed class NdbNetworkState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select the Nutanix cluster on which you want to add the VLAN.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// dns domain for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("dnsDomain")]
        public Input<string>? DnsDomain { get; set; }

        /// <summary>
        /// Gateway for vlan. Supports in Static IP address assignment only
        /// </summary>
        [Input("gateway")]
        public Input<string>? Gateway { get; set; }

        [Input("ipPools")]
        private InputList<Inputs.NdbNetworkIpPoolGetArgs>? _ipPools;

        /// <summary>
        /// Manage IP Address Pool in NDB option if you want to assign static IP addresses to your database server VMs
        /// </summary>
        public InputList<Inputs.NdbNetworkIpPoolGetArgs> IpPools
        {
            get => _ipPools ?? (_ipPools = new InputList<Inputs.NdbNetworkIpPoolGetArgs>());
            set => _ipPools = value;
        }

        /// <summary>
        /// Managed by NDB or not
        /// </summary>
        [Input("managed")]
        public Input<bool>? Managed { get; set; }

        /// <summary>
        /// Name of the vlan to be attached in NDB
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// primary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("primaryDns")]
        public Input<string>? PrimaryDns { get; set; }

        [Input("properties")]
        private InputList<Inputs.NdbNetworkPropertyGetArgs>? _properties;

        /// <summary>
        /// properties of network
        /// </summary>
        public InputList<Inputs.NdbNetworkPropertyGetArgs> Properties
        {
            get => _properties ?? (_properties = new InputList<Inputs.NdbNetworkPropertyGetArgs>());
            set => _properties = value;
        }

        [Input("propertiesMaps")]
        private InputList<Inputs.NdbNetworkPropertiesMapGetArgs>? _propertiesMaps;

        /// <summary>
        /// properties map of network
        /// </summary>
        public InputList<Inputs.NdbNetworkPropertiesMapGetArgs> PropertiesMaps
        {
            get => _propertiesMaps ?? (_propertiesMaps = new InputList<Inputs.NdbNetworkPropertiesMapGetArgs>());
            set => _propertiesMaps = value;
        }

        /// <summary>
        /// secondary dns for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("secondaryDns")]
        public Input<string>? SecondaryDns { get; set; }

        /// <summary>
        /// stretched vlan id
        /// </summary>
        [Input("stretchedVlanId")]
        public Input<string>? StretchedVlanId { get; set; }

        /// <summary>
        /// Subnet mask for vlan. (Static IP address assignment only)
        /// </summary>
        [Input("subnetMask")]
        public Input<string>? SubnetMask { get; set; }

        /// <summary>
        /// Vlan type. Supports [DHCP, Static]
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public NdbNetworkState()
        {
        }
        public static new NdbNetworkState Empty => new NdbNetworkState();
    }
}
