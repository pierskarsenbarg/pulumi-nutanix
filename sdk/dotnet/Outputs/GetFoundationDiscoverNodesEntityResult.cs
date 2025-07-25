// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetFoundationDiscoverNodesEntityResult
    {
        /// <summary>
        /// Chassis serial number.
        /// </summary>
        public readonly string BlockId;
        /// <summary>
        /// ID number of the block.
        /// </summary>
        public readonly int ChassisN;
        /// <summary>
        /// Model name of the node.
        /// </summary>
        public readonly string Model;
        /// <summary>
        /// Node level properties.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFoundationDiscoverNodesEntityNodeResult> Nodes;

        [OutputConstructor]
        private GetFoundationDiscoverNodesEntityResult(
            string blockId,

            int chassisN,

            string model,

            ImmutableArray<Outputs.GetFoundationDiscoverNodesEntityNodeResult> nodes)
        {
            BlockId = blockId;
            ChassisN = chassisN;
            Model = model;
            Nodes = nodes;
        }
    }
}
