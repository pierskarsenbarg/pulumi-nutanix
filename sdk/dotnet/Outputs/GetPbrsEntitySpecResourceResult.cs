// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetPbrsEntitySpecResourceResult
    {
        /// <summary>
        /// Routing policy action
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrsEntitySpecResourceActionResult> Actions;
        /// <summary>
        /// destination address of an IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrsEntitySpecResourceDestinationResult> Destinations;
        /// <summary>
        /// Policy in reverse direction.
        /// </summary>
        public readonly bool IsBidirectional;
        /// <summary>
        /// priority of routing policy
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// Routing policy IP protocol parameters
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrsEntitySpecResourceProtocolParameterResult> ProtocolParameters;
        /// <summary>
        /// Protocol type of routing policy
        /// </summary>
        public readonly string ProtocolType;
        /// <summary>
        /// source address of an IP.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrsEntitySpecResourceSourceResult> Sources;
        /// <summary>
        /// Reference to VPC
        /// </summary>
        public readonly ImmutableDictionary<string, string> VpcReference;

        [OutputConstructor]
        private GetPbrsEntitySpecResourceResult(
            ImmutableArray<Outputs.GetPbrsEntitySpecResourceActionResult> actions,

            ImmutableArray<Outputs.GetPbrsEntitySpecResourceDestinationResult> destinations,

            bool isBidirectional,

            int priority,

            ImmutableArray<Outputs.GetPbrsEntitySpecResourceProtocolParameterResult> protocolParameters,

            string protocolType,

            ImmutableArray<Outputs.GetPbrsEntitySpecResourceSourceResult> sources,

            ImmutableDictionary<string, string> vpcReference)
        {
            Actions = actions;
            Destinations = destinations;
            IsBidirectional = isBidirectional;
            Priority = priority;
            ProtocolParameters = protocolParameters;
            ProtocolType = protocolType;
            Sources = sources;
            VpcReference = vpcReference;
        }
    }
}