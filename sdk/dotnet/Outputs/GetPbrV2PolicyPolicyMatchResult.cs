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
    public sealed class GetPbrV2PolicyPolicyMatchResult
    {
        /// <summary>
        /// Address Type like "EXTERNAL" or "ANY".
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchDestinationResult> Destinations;
        /// <summary>
        /// Protocol Params Object.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterResult> ProtocolParameters;
        /// <summary>
        /// Routing Policy IP protocol type.
        /// </summary>
        public readonly string ProtocolType;
        /// <summary>
        /// Address Type like "EXTERNAL" or "ANY".
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchSourceResult> Sources;

        [OutputConstructor]
        private GetPbrV2PolicyPolicyMatchResult(
            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchDestinationResult> destinations,

            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterResult> protocolParameters,

            string protocolType,

            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchSourceResult> sources)
        {
            Destinations = destinations;
            ProtocolParameters = protocolParameters;
            ProtocolType = protocolType;
            Sources = sources;
        }
    }
}
