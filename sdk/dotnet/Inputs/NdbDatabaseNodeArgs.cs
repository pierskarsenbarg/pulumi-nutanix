// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class NdbDatabaseNodeArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) compute profile id
        /// </summary>
        [Input("computeprofileid")]
        public Input<string>? Computeprofileid { get; set; }

        /// <summary>
        /// - (Optional) Database server ID required for existing VM
        /// </summary>
        [Input("dbserverid")]
        public Input<string>? Dbserverid { get; set; }

        [Input("ipInfos")]
        private InputList<Inputs.NdbDatabaseNodeIpInfoArgs>? _ipInfos;

        /// <summary>
        /// - (Optional) IP infos for custom network profile.
        /// </summary>
        public InputList<Inputs.NdbDatabaseNodeIpInfoArgs> IpInfos
        {
            get => _ipInfos ?? (_ipInfos = new InputList<Inputs.NdbDatabaseNodeIpInfoArgs>());
            set => _ipInfos = value;
        }

        /// <summary>
        /// - (Required) network profile ID
        /// </summary>
        [Input("networkprofileid")]
        public Input<string>? Networkprofileid { get; set; }

        /// <summary>
        /// - (Optional) cluster id.
        /// </summary>
        [Input("nxClusterId")]
        public Input<string>? NxClusterId { get; set; }

        [Input("properties")]
        private InputList<Inputs.NdbDatabaseNodePropertyArgs>? _properties;

        /// <summary>
        /// - (Optional) list of additional properties
        /// </summary>
        public InputList<Inputs.NdbDatabaseNodePropertyArgs> Properties
        {
            get => _properties ?? (_properties = new InputList<Inputs.NdbDatabaseNodePropertyArgs>());
            set => _properties = value;
        }

        /// <summary>
        /// - (Required) name of vm
        /// </summary>
        [Input("vmname", required: true)]
        public Input<string> Vmname { get; set; } = null!;

        public NdbDatabaseNodeArgs()
        {
        }
        public static new NdbDatabaseNodeArgs Empty => new NdbDatabaseNodeArgs();
    }
}