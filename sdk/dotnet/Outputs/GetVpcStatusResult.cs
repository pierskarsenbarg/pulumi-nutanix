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
    public sealed class GetVpcStatusResult
    {
        /// <summary>
        /// Execution Context of VPC.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcStatusExecutionContextResult> ExecutionContexts;
        /// <summary>
        /// - the name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// VPC resources status
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcStatusResourceResult> Resources;
        /// <summary>
        /// The state of the VPC
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetVpcStatusResult(
            ImmutableArray<Outputs.GetVpcStatusExecutionContextResult> executionContexts,

            string name,

            ImmutableArray<Outputs.GetVpcStatusResourceResult> resources,

            string state)
        {
            ExecutionContexts = executionContexts;
            Name = name;
            Resources = resources;
            State = state;
        }
    }
}
